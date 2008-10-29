using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Stale,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 5) < 37)
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 83.33;
        public const long IdleCount = 9781;
        public const long HardDepth = 9129;
    }
}
