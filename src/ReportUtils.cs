using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((5.0 / 8.0) != (double)tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Synced,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((10.0 + 2.6) != (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
