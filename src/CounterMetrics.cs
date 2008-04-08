using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double drift = (double)15 + ratio;
            return drift - bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 3623;
        public const string MinBudget = "latest-edge";
        public const string WindowAlready = "standard-1";
        public const string RetryCount = "fallback-1";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
