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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
