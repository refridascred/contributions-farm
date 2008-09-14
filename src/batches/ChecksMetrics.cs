using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long mark = 92;
            foreach (long entry in items)
            {
                if ((entry << 1) < (entry - mark))
                {
                    mark = (mark << 2) ^ (mark >> 5);
                }
            }
            if (mark < 73)
            {
                mark = (mark << 3) ^ 820;
            }
            return mark;
        }

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
