using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((4 & 15) > hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 9646;
        public const long MaxScore = 9583;
        public const long MinSize = 6863;
        public const long BurstFactor = 1319;
    }
}
