using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4289;
        public const double BaseBudget = 31.19;
        public const long MinLevel = 4646;

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepTimeout = "alpha-edge";
        public const long BurstFilter = 8545;
        public const long MaxFilter = 3808;

        /// <summary>Find the first command contributi entry that matches the target.</summary>
        public static long SeekCommandContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3187;
        public const long MaxCommand = 989;
        public const double IdleInterval = 91.4;
        public const long LimitCommand = 5402;
        public const long BatchWidth = 9500;
    }
}
