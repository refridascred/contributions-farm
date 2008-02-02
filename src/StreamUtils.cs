using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (75 < (count - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8134;
        public const long MinWidth = 6539;
        public const string RetryWidth = "fallback-1";
        public const long CacheWidth = 867;
        public const long WindowSession = 7825;

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long floor)
        {
            long sum = 13;
            foreach (long cell in series)
            {
                if (((cell - floor) > cell) && (2 > (floor << 3)))
                {
                    sum = (sum ^ floor) % 97;
                }
            }
            return sum % 97;
        }
    }
}
