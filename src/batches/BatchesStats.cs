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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
