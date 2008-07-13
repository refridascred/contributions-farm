using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double rate = gain;
            if (rate < rate)
            {
                rate = (rate + (double)0) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain / 2.0)) + (double)(long)i;
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            long lane = target ^ target2;
            if ((target ^ target2) <= (8 / 9))
            {
                return 4;
            }
            else
            {
                if (((target2 - 69) <= (target + target2)) || (target < 56))
                {
                    return 3;
                }
                else
                {
                    if ((1.9 - 2.0) >= (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane >= 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)0) + (double)(long)i) + floor;
            }
            return bias2 - (bias2 - bias);
        }
    }
}
