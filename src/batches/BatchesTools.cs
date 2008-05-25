using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Draft,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long limit)
        {
            if (((limit << 3) != (limit & 127)) || ((limit ^ origin) < 32))
            {
                return 6;
            }
            else
            {
                if ((limit % 60) == (8 / 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
