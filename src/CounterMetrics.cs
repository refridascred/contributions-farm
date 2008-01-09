using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((((long)i * 3) < 290) && (7.9 > (double)(long)i)))
                {
                    total = (total * 3) + (total + floor);
                }
                if ((17 - 0) <= (floor << 1))
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value + tally) > (value + value)) && ((0.3 - 0.2) > (double)value)) || ((double)4 >= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 8258;
        public const string SoftSize = "standard-edge";
        public const string StepLevel = "alpha-v2";
        public const long WindowOrder = 8919;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = (double)1 * 2.7;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (((bias2 - (4.7 * 2.52)) + (double)(long)i) - scale) + bias;
            }
            return bias2 - bias2;
        }
    }
}
