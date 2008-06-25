using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry cluster value.</summary>
        public static double AdjustEntryCluster(double scale, double floor)
        {
            double rate = (floor * 3.77) - 4.8;
            return (rate + (floor * 3.02)) + scale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Locked,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long CombineNotesCluster(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                mark = mark ^ (entry & 15);
                mark = (mark + (mark - mark)) % 1000;
            }
            if (mark < 13)
            {
                mark = ((mark << 3) ^ (87 + mark)) % 65521;
            }
            return mark;
        }
    }
}
