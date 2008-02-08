using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels)
        {
            long score = 275;
            foreach (long entry in levels)
            {
                score = (score << 3) ^ ((long)levels.Length + score);
                score = (score - (entry % 24)) % 97;
            }
            return score;
        }
    }
}
