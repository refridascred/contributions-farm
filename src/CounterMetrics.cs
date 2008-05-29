using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a window already pair into a bucket.</summary>
        public static long RankWindowAlready(long floor, long step)
        {
            long offset = floor + step;
            if (((double)963 <= (double)floor) && ((floor - offset) != (floor + step)))
            {
                return 4;
            }
            else
            {
                if ((761 % 16) <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
