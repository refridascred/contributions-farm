using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryTimeout = 898;
        public const long HardQueue = 6042;
        public const long IdleCount = 1109;
        public const long MinLevel = 7808;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
