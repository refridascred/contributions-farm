using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) <= hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark ^ (mark + (long)i)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long result = 37;
            foreach (long value in items)
            {
                if (((value + result) <= (value >> 2)) && ((4.5 - 11.0) > (double)value))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 1000;
        }
    }
}
