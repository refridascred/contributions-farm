using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-v2";
        public const long BaseRecord = 7391;
        public const string BatchRecord = "local-1";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Idle,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
