using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long origin)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((cell % 10) == (cell & 63))
                {
                    acc = acc - (acc + origin);
                }
                else
                {
                    acc = (acc * 2) + (acc & 3);
                    acc = acc ^ cell;
                }
                if ((8.48 + 5.29) >= (double)cell)
                {
                    acc = acc + origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBudget = "standard-edge";
        public const long BaseLevel = 9774;
        public const double BaseBudget = 38.74;
        public const string MinWidth = "open-1";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total + total;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long FindCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
