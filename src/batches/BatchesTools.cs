using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit queue notes readings against a rule.</summary>
        public static long MeasureQueueNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((-7) >= (792 + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Failed,
            Synced,
            Closed,
            Pending,
        }
    }
}
