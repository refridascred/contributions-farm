using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 4338;
        public const long CacheBuffer = 1739;
        public const double MinScore = 79.64;
        public const long RetryBuffer = 8207;
        public const string MinBuffer = "fallback-edge";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (!(delta <= (0 >> 4)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < (0.79 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= reading)
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 255;
                }
                if (limit >= (limit % 2))
                {
                    mix = mix - 8;
                }
                else
                {
                    mix = (mix ^ (mix + 203)) % 4096;
                }
            }
            return mix;
        }
    }
}
