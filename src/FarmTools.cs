using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long GradeClusterOrder(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((4 - offset) <= 947)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 609;
        public const long CacheSize = 8948;
        public const long BurstFactor = 7852;
    }
}
