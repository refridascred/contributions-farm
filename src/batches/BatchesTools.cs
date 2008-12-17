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

        /// <summary>Define window limits and defaults.</summary>
        public const string StepInterval = "legacy";
        public const double StepWindow = 80.79;
        public const double BurstFactor = 52.36;
        public const long HardWindow = 7528;
        public const long BurstSpan = 3409;
    }
}
