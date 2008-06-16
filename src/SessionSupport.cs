using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metrics filter input into a small class.</summary>
        public static long GradeMetricsFilter(long limit, long target)
        {
            if ((target + target) < (219 & 127))
            {
                return 0;
            }
            else
            {
                if ((6.5 / 5.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((double)limit < 6.87) && ((limit + target) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
