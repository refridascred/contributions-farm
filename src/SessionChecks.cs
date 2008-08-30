using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if ((bound < (bound + limit)) || ((limit + (-55)) == (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if ((13.0 * 5.15) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound + limit) < limit) && ((4 + limit) < 209))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 63) >= (limit + bound))
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

        /// <summary>Project the next account stream value.</summary>
        public static double AdjustAccountStream(double gain, double span)
        {
            double weight = span;
            return weight - (gain / 6.0);
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double gain, double span)
        {
            double rate = (double)(3 - 164);
            if (rate >= (span / 9.0))
            {
                rate = (rate - (rate - 9.82)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 3.0)) - (double)(long)i;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double weight = (double)(0 - 76);
            if (weight > 5.67)
            {
                weight = (weight + weight) + bias;
            }
            else
            {
                weight = weight + (scale / 8.0);
            }
            return weight + (scale / 3.0);
        }
    }
}
