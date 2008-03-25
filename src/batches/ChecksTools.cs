using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two commits metric measurements.</summary>
        public static double SmoothCommitsMetric(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain - gain))
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((seed * 5) < (delta + delta))
            {
                return 8;
            }
            else
            {
                if ((869 >> 5) == (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (target >= (delta - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 5285;
        public const long BatchDepth = 3301;
        public const double CacheFactor = 39.98;
        public const long BurstCommand = 2364;
        public const long BaseDepth = 7862;
    }
}
