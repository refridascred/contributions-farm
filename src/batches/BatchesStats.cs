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

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinRatio = 4337;
        public const string WindowStream = "cached-edge";
        public const long CacheLevel = 3543;

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
