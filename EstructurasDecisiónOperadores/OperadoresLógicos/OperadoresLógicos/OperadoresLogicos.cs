using System;
using System.Collections.Generic;
using System.Text;

namespace OperadoresLógicos
{
    class OperadoresLogicos
    {
        public void Operadoreslogicos() {


            int num1, num2, num3, num4, num5;
            Console.WriteLine("Favor ingresar el valor No. 1\n");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingresar el valor No. 2\n");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingresar el valor No. 3\n");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingresar el valor No. 4\n");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingresar el valor No. 5\n");
            num5 = int.Parse(Console.ReadLine());
            if (num1 < 3)
            {
                Console.WriteLine("El valor de " + num1 + " es menor que 3.");
            }
            else if (num2 != num1)
            {
                Console.WriteLine("El valor de " + num2 + " es diferente al valor de " + num1);
            }
            else if (num3 > 5)
            {
                Console.WriteLine("El valor de " + num3 + " es mayor que 5.");
            }
            else if (num4 == num5)
            {
                Console.WriteLine("El valor de " + num4 + " es igual al valor de " + num5);
            }
            else if (num1 + num4 > num5 * num2)
            {
                Console.WriteLine("La suma de los valores " + num1 + " y " + num2 + " es mayor que la multiplicación de " + num5 + " por " + num2);
            }
            else if (num1 > 3 & num2 < 10)
            {
                Console.WriteLine("El valor de " + num1 + " es mayor a 3 y " + num2 + " es menor que 10.");
            }
            else if (num1 > 3 && num2 < 10)
            {
                Console.WriteLine("El valor de " + num1 + " es mayor a 3 y " + num2 + " es menor que 10, decisión con cortocircuito.");
            }
            else if (num2 < 3 | num3 > 15)
            {
                Console.WriteLine("El valor de " + num2 + " es menor que 3 y " + num3 + " es mayor que 15.");
            }
            else if (num2 < 3 || num3 > 15)
            {
                Console.WriteLine("El valor de " + num2 + " es menor que 3 y " + num3 + " es mayor que 15.");
            }
            else if (num1 != 7 | num2 < 12) 
            {
                Console.WriteLine("El valor de " + num1 + " es igual a 7 o " + num2 + " es menor que 12.");
            }
            else
            {
                Console.WriteLine("Niguna de las condiciones anteriores aplica");
            }
        }
    }
}
