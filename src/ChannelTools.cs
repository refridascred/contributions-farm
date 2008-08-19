using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values, long bound)
        {
            long acc = 180;
            foreach (long entry in values)
            {
                if (((entry & 31) == (acc ^ acc)) && (entry >= (acc % 64)))
                {
                    acc = (((acc << 3) ^ (entry % 12)) % 255) - bound;
                }
            }
            return acc % 65521;
        }
    }
}
