using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long TallyBatchAlreadyOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 1) >= matches)
                {
                    matches = ((matches + 3) ^ reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 26.82;
        public const long CacheDepth = 9767;
        public const double HardCount = 89.22;
        public const double DefaultBudget = 74.78;
        public const long BaseLevel = 1850;
    }
}
