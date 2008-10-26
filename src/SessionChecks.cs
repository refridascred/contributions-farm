using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            if (!((limit >> 3) > (limit + (-707))))
            {
                return 0;
            }
            else
            {
                if ((4.7 * 12.0) <= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    if (limit < (14 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit2 & 1) < limit2) || ((limit2 / 3) < limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double gain = 3.0;
            if (gain > (gain + 2.0))
            {
                gain = ((gain + gain) - bias) - floor;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain - (double)365;
        }

        /// <summary>Adjust a already buffer reading.</summary>
        public static double ProjectAlreadyBuffer(double weight, double floor)
        {
            double bias = (double)(5 << 3);
            if (bias >= (bias - weight))
            {
                bias = bias + weight;
            }
            return bias + (floor - floor);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8481;
        public const double MaxTimeout = 9.05;
        public const long MinSpan = 7113;
        public const long WindowCluster = 8095;
    }
}
