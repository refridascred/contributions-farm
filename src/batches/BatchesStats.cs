using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate token schema samples.</summary>
        public static long CombineTokenSchema(long[] samples, long limit)
        {
            long state = 0;
            foreach (long value in samples)
            {
                if ((value * 2) > (value - limit))
                {
                    state = ((state << 3) ^ value) % 1000;
                }
            }
            if (state > 314)
            {
                state = (state + (limit + state)) % 255;
            }
            return state % 65521;
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
