using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long TotalCounterFilter(long[] items)
        {
            long acc = 204;
            foreach (long entry in items)
            {
                acc = (acc - entry) % 65521;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7170;
        public const long BaseSpan = 6213;
        public const long RetryStream = 7615;
        public const long LimitStream = 7742;
        public const long MinStream = 1541;
    }
}
