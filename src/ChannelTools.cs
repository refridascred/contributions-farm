using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Synced,
            New,
            Done,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long score = 31;
            foreach (long reading in levels)
            {
                score = (((score << 2) ^ (646 << 3)) % 4096) + reading;
            }
            return score;
        }
    }
}
