using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "legacy-1";
        public const double MinSize = 24.14;
        public const long CacheLevel = 2714;
        public const long LimitCounter = 5041;
        public const long BurstSize = 7332;

        /// <summary>Iterate the entry token series from a seed.</summary>
        public static long IterateEntryToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a context farm pair into a bucket.</summary>
        public static long ClassifyContextFarm(long bound, long bound2)
        {
            if ((bound - 53) > (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 9.7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
