using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-edge";
        public const long BurstAlready = 3642;
        public const long LimitDepth = 3687;
        public const long BaseRatio = 8090;

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

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double drift = (double)79 * 7.0;
            return ((drift - 14.0) + bias) + span;
        }
    }
}
