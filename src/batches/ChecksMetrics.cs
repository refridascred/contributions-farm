using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinTimeout = 7758;
        public const string StepDepth = "fallback-v2";
        public const double StepGraph = 33.34;
        public const double MaxGraph = 97.81;
        public const double BurstGraph = 0.7;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 206;
        public const string MaxBuffer = "fallback-1";
        public const long CacheWidth = 5903;
        public const string MinBuffer = "alpha";

        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long TallyTokenEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 6.5)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the queue commits entries that pass the check.</summary>
        public static long CountQueueCommitsHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + offset) <= offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
