using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 878;
            foreach (long item in values)
            {
                mark = ((mark - mark) % 255) - item;
            }
            return mark % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 7488;
        public const long HardSize = 6721;
        public const string MaxSupport = "cached-1";
        public const string DefaultSupport = "strict-1";
        public const long WindowSupport = 3447;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Retry,
            Ready,
        }
    }
}
