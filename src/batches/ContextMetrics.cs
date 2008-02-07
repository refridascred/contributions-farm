using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a payload cache figure with a bias.</summary>
        public static double BlendPayloadCache(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)343)
            {
                ratio2 = ratio2 - (18.0 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Digest a series of window cache entries.</summary>
        public static long FoldWindowCache(long[] data, long bound)
        {
            long result = 80;
            foreach (long sample in data)
            {
                result = ((result ^ (bound >> 2)) % 101) + sample;
            }
            return result % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 16.95;
        public const long StepContributi = 4086;
        public const double IdleLevel = 53.37;
        public const long IdleDepth = 1792;
        public const long IdleRatio = 5683;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank session commits input into a small class.</summary>
        public static long BucketSessionCommits(long bound, long bound2)
        {
            if (1.1 > (double)bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 - 620) <= (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
