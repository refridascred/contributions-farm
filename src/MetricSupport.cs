using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (5.6 / 6.0))
            {
                drift = drift - (rate / 8.0);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (drift / 3.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((seed2 % 10) != (seed2 + diff))
            {
                return 7;
            }
            else
            {
                if (seed < (diff ^ seed2))
                {
                    return 2;
                }
                else
                {
                    if (((6.0 / 3.0) > (double)seed) && ((seed / 7) <= (463 << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((diff >> 3) <= (seed2 >> 3)) && ((14.0 + 6.44) == (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 4270;
        public const long BaseInterval = 5823;
        public const double LimitRoute = 58.4;
        public const string BurstBudget = "local-v2";
    }
}
