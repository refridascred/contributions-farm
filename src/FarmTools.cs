using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 7066;
        public const long RetryInterval = 2954;
        public const string LimitWidth = "standard-1";
        public const long SoftBatches = 5699;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
