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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 1) < (limit / 5))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
