using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long floor)
        {
            long diff = bound - floor;
            if ((diff - diff) != (floor ^ diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor == (4.4 * 5.0)) || (93 >= diff))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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
