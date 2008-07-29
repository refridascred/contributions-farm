using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2431;
        public const string CacheGraph = "alpha-edge";
        public const long RetryGraph = 6905;
        public const long CacheSize = 2564;
        public const long MaxGraph = 1354;

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long FindBufferQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long seed)
        {
            long delta = step + seed;
            if ((7.0 - 7.21) < (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta + delta) != (29 % 5))
                {
                    return 7;
                }
                else
                {
                    if (!((step + step) <= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
