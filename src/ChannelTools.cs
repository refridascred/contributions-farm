using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long target)
        {
            long lane = seed - target;
            if ((11.0 * 15.0) > (double)lane)
            {
                return 8;
            }
            else
            {
                if ((target + 6) <= (target - seed))
                {
                    return 1;
                }
                else
                {
                    if (((lane + target) >= seed) && ((target >> 2) >= (31 >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((1.1 + 9.0) > (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double ScaleRouteFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain + (double)3) - floor;
            }
            return gain + (weight / 7.0);
        }
    }
}
