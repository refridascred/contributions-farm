using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double drift = (double)6 - (double)2;
            return ((drift + (7.6 + drift)) + ratio) + floor;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long step)
        {
            long offset = target + step;
            if ((double)step > (2.75 + 4.0))
            {
                return 1;
            }
            else
            {
                if ((step > (offset - step)) || ((offset ^ step) >= step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next metrics editor value.</summary>
        public static double ScaleMetricsEditor(double weight, double bias)
        {
            double bias2 = (weight / 9.0) / 6.0;
            if (bias2 > bias)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - (3.2 / 8.0);
        }
    }
}
