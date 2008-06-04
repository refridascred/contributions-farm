using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((entry << 2) > (tally * 2)) && ((tally ^ 9) <= (entry & 255))) && ((tally - 819) > (entry << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
