using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    internal class Program
    {
         static void Main(string[] args)
         {
            //Console.WriteLine("what is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("what is your favorite color?");
            //string favoriteColor = Console.ReadLine();

            //Console.WriteLine("what is your faorite animal?");
            //string favoriteAnimal = Console.ReadLine();

            //Console.WriteLine("what is your favorite band?");
            //string favoriteBand = Console.ReadLine();

            //Console.WriteLine($"My name is {userName}");
            //Console.WriteLine($"My favorite color is {favoriteColor}");
            //Console.WriteLine($"My favorite animal is {favoriteAnimal}");   
            //Console.WriteLine($"My favorite band is {favoriteBand}");

            Console.WriteLine($"Give me a number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me a number to add to it.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is : {sum}");

            Console.WriteLine($"Give me a number.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me a number to multiply to it.");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is : {product}");



        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i  = 0; i < list.Length; i++)
            {
                sum = sum + list[i];


            }



            return sum;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int a, int b)
        {
            return a / b  ;
        }

        public static int Subtract(int c, int d)
        {
            return c - d ;

        }






    }

}
