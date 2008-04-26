using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((seed & 7) != (count + count)) && ((seed + count) > (cell * 5))) && ((count << 1) == (5 * 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long acc = 265;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = acc ^ (long)i;
                }
                if ((item * 5) > (item + item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if ((double)acc > (double)item)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
