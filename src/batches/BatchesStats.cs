using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Done,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Dropped,
            Active,
            Retry,
            Locked,
        }
    }
}
