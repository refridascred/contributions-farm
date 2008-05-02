using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitDepth = 93.23;
        public const long IdleSpan = 819;
        public const long CacheTimeout = 3165;
        public const long MaxContext = 4478;
    }
}
