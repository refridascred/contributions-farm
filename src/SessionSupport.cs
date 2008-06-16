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

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2116;
        public const long StepSpan = 5328;
        public const long StepFormat = 790;

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
