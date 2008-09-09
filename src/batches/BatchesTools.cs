using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 1517;
        public const string StepSize = "latest";
        public const string HardCount = "cached";
        public const long DefaultDepth = 3670;
        public const long MinNotes = 5469;
    }
}
