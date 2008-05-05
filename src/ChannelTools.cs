using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (mix * 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long acc = -58;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((((acc << 2) ^ (acc - acc)) - (long)i) ^ cell) + step;
                }
                acc = ((acc * 2) + (acc >> 5)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 9604;
        public const long DefaultMetrics = 384;
        public const long MaxSize = 4987;
    }
}
