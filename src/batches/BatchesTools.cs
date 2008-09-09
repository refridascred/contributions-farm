using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long total = -9;
            foreach (long sample in data)
            {
                total = (total ^ (8 + sample)) % 101;
            }
            return total;
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
