using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your Name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine(
                $"One day, {userName} was walking through the woods while wearing a {favColor} T-Shirt. {userName} saw a {favAnimal} listening to {favBand}, ");
        }

        public static int Add(int numberOne, int NumberTwo)
        {
            return numberOne + NumberTwo;
        }
        
        public static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static int Divide(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
               // Sum = sum + numbers;
               sum += number;
            }

            return sum;

        }

        static void Main(string[] args)
        {
           //Madlib();
          //Console.WriteLine(Add(numberOne:10, NumberTwo:10));
          //int addednums = Add(numberOne: 5, NumberTwo: 5);
          //Console.WriteLine(addednums);
          //Console.WriteLine(Subtract(numberOne:10, numberTwo:20));
          //Console.WriteLine(Multiply(10, 10));
          //Console.WriteLine(Divide(25, numberTwo:5));
          Console.WriteLine(Sum(5));
          Console.WriteLine(Sum(5, 10, 30));
        }
    }
}