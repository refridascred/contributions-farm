using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long target)
        {
            if ((target % 5) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if (!((target * 4) != (target << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target >= (1.13 - 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double drift = (double)79 * 7.0;
            return ((drift - 14.0) + bias) + span;
        }
    }
}
