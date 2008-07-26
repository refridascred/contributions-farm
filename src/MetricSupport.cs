using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound > ((-28) >> 3)) && ((7.2 * 20.0) < (6.0 / 9.0)))
            {
                return 3;
            }
            else
            {
                if (seed <= (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if (seed >= (origin * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.6 / 4.0) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token profile reading.</summary>
        public static double ScaleTokenProfile(double ratio, double offset)
        {
            double drift = (double)42 * 4.16;
            if (drift <= (4.44 / 3.0))
            {
                drift = ((drift - (drift / 9.0)) + ratio) - offset;
            }
            else
            {
                drift = drift + (double)(-22);
            }
            return drift - 3.4;
        }
    }
}
