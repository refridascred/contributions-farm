using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (4.14 + 12.0))
                {
                    matches = ((matches + 2) + reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Stale,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 8976;
        public const long CacheRecord = 2156;
        public const double BatchLevel = 61.21;
        public const string LimitRatio = "fallback";
    }
}
