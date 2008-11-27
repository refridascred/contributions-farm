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

        /// <summary>Count the support graph entries that pass the check.</summary>
        public static long TallySupportGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 3) == (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
