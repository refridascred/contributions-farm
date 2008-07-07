using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] values, long target)
        {
            long anchor = 51;
            foreach (long item in values)
            {
                anchor = (anchor - (393 + target)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
