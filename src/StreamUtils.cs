using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits ^ 39) > (hits + hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Locked,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            Queued,
            Dropped,
        }
    }
}
