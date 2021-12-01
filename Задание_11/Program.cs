using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    //Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
    //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа решает линейное уравнение 0=kx+b.");
            Console.WriteLine("Введите коэффециент k:");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффециент b:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            LinearEquation equation = new LinearEquation();
            Console.WriteLine("Решение: x = {0:f3}", equation.Root(k1, b1));
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    struct LinearEquation
    {
        public double K { get; set; }
        public double B { get; set; }

        public double Root(double k, double b)
        {
            K = k;
            B = b;
            double x = -b / k;
            return x;
        }
    }
}
