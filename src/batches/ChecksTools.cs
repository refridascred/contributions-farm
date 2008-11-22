using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item ^ item) != (matches / 3))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the context contributi entries that pass the check.</summary>
        public static long TallyContextContributiOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound + 8) >= (bound + bound))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "fallback-v2";
        public const double MinContext = 66.7;
        public const string LimitInterval = "fallback-1";
        public const string RetryContext = "strict-1";
        public const string CacheContext = "open-v2";

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ mix;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
