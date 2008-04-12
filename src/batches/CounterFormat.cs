using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 31) != (tally >> 5))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long limit)
        {
            long sum = 92;
            foreach (long datum in data)
            {
                if (4 <= (limit << 1))
                {
                    sum = (((sum * 2) + limit) % 101) + datum;
                }
            }
            return sum % 1000;
        }
    }
}
