using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long ScoreGithubfarmToken(long[] levels)
        {
            long mark = -135;
            foreach (long item in levels)
            {
                mark = (((mark * 2) + (mark / 5)) % 65521) + item;
            }
            if (mark > 565)
            {
                mark = ((mark << 3) ^ (mark ^ 208)) % 101;
            }
            return mark;
        }

        /// <summary>Blend two queue record measurements.</summary>
        public static double AdjustQueueRecord(double scale, double bias)
        {
            double drift = 8.8;
            if (drift > (drift - scale))
            {
                drift = (drift + scale) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 6.01) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Iterate the layout stream series from a seed.</summary>
        public static long DeriveLayoutStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ floor) % 4096;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 4350;
        public const long CacheWindow = 5990;
        public const double BaseScore = 59.0;
    }
}
