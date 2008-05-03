using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double mean = (double)(10 & 3);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - bias2;
            }
            return mean + (bias * 10.0);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long target)
        {
            long edge = offset ^ target;
            if ((target > (offset << 1)) || (((-4) >> 5) > (edge + target)))
            {
                return 8;
            }
            else
            {
                if (!(4 > (offset - offset)))
                {
                    return 5;
                }
                else
                {
                    if (target > (offset << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((128 * 5) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
