namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcion = "";

            while (opcion != "0")
            {
                MostrarMenu();
                opcion = PedirPalabras("Ingrese una opcion -> ");

                switch (opcion)
                {
                    case "1":
                        Saludo();
                        break;
                    case "2":
                        Suma();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo ...");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                } 
            }
        }

        #region METODOS AUXILIARES

        static void MostrarMenu()
        {
            Console.Clear();
            MostrarMensajeColor(ConsoleColor.Cyan, "****************");
            MostrarMensajeColor(ConsoleColor.Cyan, "      MENU      ");
            MostrarMensajeColor(ConsoleColor.Cyan, "****************");
            Console.WriteLine();
            Console.WriteLine("1 - Saludo");
            Console.WriteLine("2 - Suma");
            Console.WriteLine("0 - Salir");
        }

        /// <summary>
        /// Este metodo pide al usuario informacion y retorna un string con lo ingresado
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        static string PedirPalabras(string mensaje)
        {
            Console.Write(mensaje);
            string datos = Console.ReadLine();
            return datos;
        }

        static int PedirNumeros(string mensaje)
        {
            bool exito = false;
            int valorConvertido = 0;

            while (exito == false)
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out valorConvertido);

                if (exito == false)
                {
                    MostrarError("ERROR: Debe ingresar solo numeros");
                }
            }

            return valorConvertido;
        }

        static void MostrarMensajeColor(ConsoleColor color1, string mensaje)
        {
            Console.ForegroundColor = color1;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PressToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
        }

        #endregion

        #region METODOS DE MENU

        static void Saludo()
        {
            Console.Clear();
            MostrarMensajeColor(ConsoleColor.Yellow, "FUNCIONALIDAD SALUDO");
            Console.WriteLine();

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Bienvenido {nombre}");

            PressToContinue();
        }

        static void Suma()
        {
            Console.Clear();
            MostrarMensajeColor(ConsoleColor.Yellow, "FUNCIONALIDAD SUMA");
            Console.WriteLine();

            int num1 = PedirNumeros("Ingrese primer numero: ");
            int num2 = PedirNumeros("Ingrese segundo numero: ");
            Console.WriteLine($"La suma es {num1 + num2}");

            PressToContinue();
        }

        #endregion
    }
}
