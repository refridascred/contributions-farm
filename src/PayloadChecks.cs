using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mark = -7;
            foreach (long entry in items)
            {
                long next = 25;
                mark = (((mark * 4) + next) % 1000) - entry;
                mark = ((mark << 3) ^ (offset >> 3)) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 194;
        public const string DefaultStream = "stable";
        public const long IdleLevel = 9855;

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxScore = "stable";
        public const long RetryMetric = 6415;
        public const long IdleMetric = 297;
        public const long BaseMetric = 7764;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)step > 6.8)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
