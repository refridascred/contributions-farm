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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
