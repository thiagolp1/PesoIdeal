Double altura, pesoideal;
String sexo;

Console.Write("Digite sua altura em m..........: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]asculino / [F]eminino...: ");
sexo = Console.ReadLine()!.ToUpper().Trim();

if (sexo != "M" && sexo != "F")
{
    Console.WriteLine("Não calculavel");
}

else 
{
     if (sexo == "M")
     {
         pesoideal = altura * 72.7 - 58.0;
     }
     else 
     {
         pesoideal = altura * 62.1 - 44.7;
     }

     Console.WriteLine($"Seu peso ideal é {pesoideal:N1}kg.");
}