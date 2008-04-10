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

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (bias - 8.0)) + (double)(long)i) + scale;
            }
            return bias2 - (bias2 + bias);
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
