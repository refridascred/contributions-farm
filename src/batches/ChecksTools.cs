using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long TallyLayoutCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((453 - value) < value) || ((value * 2) > (value >> 2))) && ((hits - value) < (hits * 3)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of window session readings.</summary>
        public static long OverlapWindowSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((4.7 * 8.81) < 0.62)
                {
                    seen = ((seen + 1) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchTimeout = 9817;
        public const long CacheChecks = 1608;
        public const string MaxLevel = "fallback-edge";
        public const long IdleWidth = 8292;
    }
}
