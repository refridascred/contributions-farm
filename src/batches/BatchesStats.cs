using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 1.73;
        public const long LimitLevel = 6227;
        public const long DefaultSpan = 3067;
        public const long BatchDepth = 1210;
        public const string CacheQueue = "standard-v2";
    }
}
