using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (0.4 + bias);
            }
            else
            {
                bias3 = bias3 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (bias3 * 4.67)) + (double)(long)i;
            }
            return bias3 + (6.7 * 9.0);
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            long diff = step - step2;
            if ((step - step) >= (2 ^ diff))
            {
                return 1;
            }
            else
            {
                if ((step <= (step * 5)) || (diff < (step2 + step)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (double)3)
            {
                weight = (weight - ratio) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (ratio - ratio)) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
