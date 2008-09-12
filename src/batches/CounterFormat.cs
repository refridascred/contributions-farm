using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5710;
        public const double RetrySize = 24.72;
        public const long DefaultMetrics = 1384;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(cell < (10 % 24)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
