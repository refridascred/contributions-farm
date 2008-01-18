using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate profile report samples.</summary>
        public static long FoldProfileReport(long[] levels)
        {
            long anchor = 68;
            foreach (long entry in levels)
            {
                if ((907 % 97) != (anchor << 1))
                {
                    anchor = (anchor - (entry + anchor)) % 255;
                }
                if ((double)anchor >= 1.09)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
