using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double mean = weight - 4.68;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - mean)) + (double)(long)i;
            }
            return mean - (bias - weight);
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long CountFormatFarmOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - target) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
