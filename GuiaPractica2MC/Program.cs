using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica2MC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Escoja una opcion");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("5 - Ejercicio 5");
                Console.WriteLine("6 - Ejercicio 6");
                Console.WriteLine("0 - Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Ejercicio6();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        static void Ejercicio1()
        {
            string nombre;

            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine().ToLower();
            char[] array = nombre.ToCharArray();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (array[i] == 'a')
                {
                    array[i] = '#';
                }
                else if (array[i] == 'e')
                {
                    array[i] = '%';
                }
                else if (array[i] == 'i')
                {
                    array[i] = '$';
                }
                else if (array[i] == 'o')
                {
                    array[i] = '?';
                }
                else if (array[i] == 'u')
                {
                    array[i] = '*';
                }
            }

            Console.WriteLine(array);
            
        }

        private static void Ejercicio2()
        {
            string producto;
            int cantidad;
            double precio;

            Console.WriteLine("Ingrese el nombre del producto");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad del producto");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            double subTotal = precio * cantidad;

            Console.WriteLine("Nombre: {0}\nSubtotal: {1:N2}\nIva: {2:N2}\nTotal a pagar: {3:N2}", producto, subTotal, subTotal * 0.13, subTotal += (subTotal * 0.13));
        }

        private static void Ejercicio3()
        {
            string directorio = Directory.GetCurrentDirectory();
            string[] array = directorio.Split('\\');
            for (int i = 0; i < 3; i++)
            {
                Console.Write(array[i] + "\\");
            }
        }

        private static void Ejercicio4()
        {
            DateTime fechaInicio, fechaFinal;
            double precio;
            Console.WriteLine("Alquiler de autos");
            Console.WriteLine("Ingrese la fecha de inicio del alquiler");
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolucion del alquiler");
            fechaFinal = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Precio del alquiler");
            precio = Convert.ToDouble(Console.ReadLine());

            double diferencia = fechaFinal.Subtract(fechaInicio).TotalDays;

            Console.WriteLine("Dias transcurridos: {0}\nTotal a pagar: {1:N2}", diferencia, diferencia * precio);
        }

        private static void Ejercicio5()
        {
            DateTime fechaInicio, fechaFinal;
            double precioMinuto;
            int telefono;
            Console.WriteLine("Ingrese su numero de telefono");
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de inicio");
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la hora final");
            fechaFinal = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Precio del minuto");
            precioMinuto = Convert.ToDouble(Console.ReadLine());

            double minutosTransc = fechaFinal.Subtract(fechaInicio).TotalMinutes;

            Console.WriteLine("Minutos trascurridos: {0}\nTotal a pagar: {1:N2}", minutosTransc, minutosTransc * precioMinuto);
        }

        private static void Ejercicio6()
        {
            Console.WriteLine("Hoy es {0}", DateTime.Now.ToString("dddd dd MMMM yyyy hh:mm tt"));
        }
    }
}
