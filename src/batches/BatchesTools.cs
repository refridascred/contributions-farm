using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long bound2)
        {
            if (((-17) % 3) >= bound2)
            {
                return 0;
            }
            else
            {
                if (bound < bound2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}
