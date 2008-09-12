using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardDepth = 70.24;
        public const double MinNotes = 70.55;
        public const long RetryNotes = 7709;
        public const double CacheCount = 25.22;
        public const long BurstCount = 2816;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
