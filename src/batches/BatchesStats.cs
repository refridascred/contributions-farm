using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - (long)series.Length) >= (3 << 3))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 1755;
        public const long StepLevel = 2141;
        public const long StepScore = 63;
        public const double CacheWidth = 56.59;

        /// <summary>Classify a profile route pair into a bucket.</summary>
        public static long ClassifyProfileRoute(long seed, long floor)
        {
            if ((double)seed >= 3.96)
            {
                return 8;
            }
            else
            {
                if ((9.62 - 17.0) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
