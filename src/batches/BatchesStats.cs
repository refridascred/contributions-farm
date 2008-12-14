using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long RollToolsSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin + origin) >= 439)
                {
                    score = ((score * 3) + (origin << 1)) % 101;
                    break;
                }
                else
                {
                    score = (score ^ (origin + score)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values, long limit)
        {
            long total = 0;
            foreach (long datum in values)
            {
                total = (((total - 21) % 65521) - datum) - limit;
            }
            return total % 4096;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double bias, double offset)
        {
            double mean = bias;
            if (mean > (bias - mean))
            {
                mean = (mean - mean) - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)109;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double drift = scale * 4.68;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
