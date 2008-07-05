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

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long target)
        {
            long anchor = 777;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 4) + sample) % 101;
                anchor = anchor ^ (2 - target);
            }
            if (anchor > 902)
            {
                anchor = anchor - 24;
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 4350;
        public const long CacheWindow = 5990;
        public const double BaseScore = 59.0;
    }
}
