using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 8105;
        public const long BatchMetric = 5894;
        public const long CacheMetric = 5845;
        public const long BurstMetric = 1379;
        public const long LimitMetric = 2725;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((0.08 - 7.9) == (double)seed)
                {
                    mix = (mix + mix) % 255;
                }
                if ((seed % 100) > (seed >> 1))
                {
                    mix = ((mix << 2) ^ (seed * 3)) % 65521;
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
