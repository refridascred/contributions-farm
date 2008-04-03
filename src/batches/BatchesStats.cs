using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
