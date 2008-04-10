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

        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long RollBufferToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((-134) + seed) == (seed + seed))
                {
                    mix = (mix * 3) + (long)i;
                    break;
                }
                if (((7.17 / 6.0) != (double)(long)i) || ((seed >> 2) >= (mix >> 4)))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

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
