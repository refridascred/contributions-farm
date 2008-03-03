using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Draft,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "latest-v2";
        public const long RetryCache = 3427;
        public const string RetryLevel = "fallback-edge";
        public const long DefaultScore = 2621;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((0.4 * 8.7) != (double)carry)
                {
                    carry = (carry + (780 ^ 3)) % 1000;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entry entries.</summary>
        public static long CombineCacheEntry(long[] items, long bound)
        {
            long anchor = 75;
            foreach (long entry in items)
            {
                if ((2.9 - 12.0) < (double)entry)
                {
                    anchor = (((anchor << 3) ^ ((-60) - anchor)) % 97) - bound;
                }
            }
            return anchor % 65521;
        }
    }
}
