using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 2; int b = 3; int c = 15;
            double p1 = Math.Sqrt((Math.Pow(a, 2) - Math.Pow(b, 3)) / Math.Sqrt(Math.Pow(b, 4) - Math.Pow(a, 4)) + Math.Abs(Math.Pow(b, 5) - Math.Pow(c, 2.5)));


            Console.WriteLine(p1);

            // задание №2

            Random rnd = new Random();
            int d = rnd.Next();
            int e = rnd.Next();
            double f = Math.Pow(d, 2) + Math.Pow(e, 1 / 3) / (d + e);

            Console.WriteLine();
            Console.WriteLine(f);

            // задание №3

            double g = 5.93576;
            int h = (int)g;
            int q = (int)(Math.Round(g));
            int w = (int)(Math.Floor(g));
            double t = Math.Round(g, 1);
            int y = 5;


            Console.WriteLine();
            Console.WriteLine(q);
            Console.WriteLine();
            Console.WriteLine(w);
            Console.WriteLine();
            Console.WriteLine(t);
            Console.WriteLine();
            Console.WriteLine(y++);
            Console.WriteLine();
            Console.WriteLine(++y);

            // задание 4

            Random rnd1 = new Random();
            int i = rnd1.Next(0, 1000);

                }
                else Console.WriteLine("ошибка");
                break;
            }
            // Задание 2
            Console.WriteLine("введите число");
            int num = 10;
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("BuzzFizz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

            // Задание 3

        }
    }
}
