var sequence = new[] { 42, 87, 112, 176 };
Console.WriteLine( MultiplySequence(sequence));

static int MultiplySequence( IEnumerable<int> sequence )
{
    int total = 1;
	foreach (var i in sequence)
	{
		total *= i;
	}

	return total;
}