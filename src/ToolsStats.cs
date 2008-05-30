using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 4738;
        public const long WindowInterval = 8876;
        public const long IdleSpan = 2754;
        public const long DefaultCluster = 9292;
        public const string CacheCluster = "primary-v2";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((offset >> 2) >= (73 >> 5))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long mark = -4;
            foreach (long item in series)
            {
                mark = (mark - (mark + 459)) - item;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowTimeout = 4885;
        public const long IdleBudget = 7179;
        public const long MinWidth = 5148;
        public const long RetrySize = 3143;
        public const long MaxAccount = 3403;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
