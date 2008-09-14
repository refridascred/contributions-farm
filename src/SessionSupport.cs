using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue metrics reading.</summary>
        public static double BlendQueueMetrics(double ratio, double floor)
        {
            double drift = (ratio / 6.0) * 9.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 0.7) - (double)(long)i) - floor;
            }
            return drift + (7.9 / 4.0);
        }

        /// <summary>Classify a cluster metrics pair into a bucket.</summary>
        public static long ClassifyClusterMetrics(long seed, long origin)
        {
            if (((origin + seed) == (seed + 2)) && ((5.8 - 0.42) != (double)origin))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (origin & 255))
                {
                    return 7;
                }
                else
                {
                    if (((-1) + seed) >= (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin < 5.61)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 6738;
        public const long WindowTimeout = 19;
        public const long WindowInterval = 8463;
        public const long RetryMetric = 9378;
    }
}
