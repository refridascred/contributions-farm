using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 3) <= hits)
                {
                    hits = ((hits + 3) + reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Paused,
            Done,
            Idle,
        }
    }
}
