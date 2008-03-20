using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9181;
        public const string HardSize = "latest-1";
        public const long IdleFilter = 8568;
        public const string HardLevel = "fallback-v2";
        public const string CacheSpan = "local-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6439;
        public const long CacheEntry = 2876;
        public const string MinEntry = "staging-1";
        public const string StepEntry = "standard";
        public const long DefaultTimeout = 7652;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 9) >= matches)
                {
                    matches = ((matches + 1) + entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
