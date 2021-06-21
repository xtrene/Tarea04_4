using System;

namespace Tarea04_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número: ");
            int num1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Escribe otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los dos números son iguales");
            }
            else

            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            Console.ReadKey();

        }
    }
}
