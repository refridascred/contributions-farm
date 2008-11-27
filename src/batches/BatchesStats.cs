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

        /// <summary>Project the next channel graph value.</summary>
        public static double SmoothChannelGraph(double ratio, double offset)
        {
            double mean = (double)43 / 2.0;
            return ((mean + (double)6) + ratio) + offset;
        }

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
