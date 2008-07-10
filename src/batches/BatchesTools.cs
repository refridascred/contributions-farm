using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultRatio = "stable-edge";
        public const string IdleSpan = "strict-1";
        public const double HardScore = 92.71;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 4928;
        public const long MaxDepth = 2798;
        public const string DefaultInterval = "stable";
        public const long HardBudget = 3680;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
