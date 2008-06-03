using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftDepth = 20.3;
        public const long StepWindow = 6388;
        public const long CacheCount = 5605;
        public const long BatchInterval = 8050;

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double scale = offset;
            if (scale > 3.17)
            {
                scale = (scale + (double)664) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 6.8) + (double)(long)i;
            }
            return scale + (double)75;
        }

        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long BucketCacheGithubfarm(long bound, long offset)
        {
            long step = bound + offset;
            if ((offset + (-7)) >= (offset * 5))
            {
                return 1;
            }
            else
            {
                if ((776 >> 4) >= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
