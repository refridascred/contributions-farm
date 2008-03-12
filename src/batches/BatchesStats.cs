using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftDepth = "strict-edge";
        public const double BurstTimeout = 64.52;
        public const string BaseTimeout = "legacy-v2";
        public const long MaxSupport = 281;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached-v2";
        public const long HardCount = 5824;
        public const double BurstFilter = 94.46;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
