using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryScore = "cached";
        public const long MinFilter = 4379;
        public const long CacheFilter = 3146;
        public const long RetryFilter = 1621;
        public const long BaseSpan = 5132;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series)
        {
            long mark = -5;
            foreach (long value in series)
            {
                if ((62 ^ value) != (0 & 15))
                {
                    mark = mark ^ (1 + mark);
                }
                if (value > (value + value))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
