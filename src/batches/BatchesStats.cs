using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Dropped,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Audit format batch readings against a rule.</summary>
        public static long TallyFormatBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((count + count) <= (entry ^ 6)) || ((count - entry) <= (count & 7))) || (count > (count + 54)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
