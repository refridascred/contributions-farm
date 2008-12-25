using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 967;
            foreach (long entry in values)
            {
                if ((8.04 * 2.43) < (double)carry)
                {
                    carry = (carry - (entry * 3)) % 101;
                }
                carry = carry ^ (carry + entry);
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
