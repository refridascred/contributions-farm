using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if ((seed ^ seed) >= (seed - seed))
            {
                return 2;
            }
            else
            {
                if (seed >= (limit % 7))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 4039;
        public const string HardFilter = "fallback-1";
        public const long StepFilter = 2266;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Paused,
            Retry,
            Done,
            Ready,
        }
    }
}
