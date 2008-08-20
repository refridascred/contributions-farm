using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 43.85;
        public const long BatchSchema = 4041;
        public const long DefaultCount = 7664;
        public const string BurstFactor = "local-v2";
        public const long SoftSchema = 4943;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Idle,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryCount = 5288;
        public const long MaxReport = 5627;
        public const string CacheReport = "open";
        public const double BatchReport = 40.42;
        public const long StepReport = 2733;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
