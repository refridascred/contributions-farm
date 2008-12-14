using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
