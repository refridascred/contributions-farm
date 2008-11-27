using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5559;
        public const long LimitBuffer = 3318;
        public const long SoftTimeout = 841;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Failed,
            New,
            Synced,
        }
    }
}
