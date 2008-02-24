using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double gain2 = bias * 2.59;
            if (gain2 < (16.0 / 3.0))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (double)6) + (double)(long)i;
            }
            return gain2 + (double)4;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            long slot = step + floor;
            if ((floor - slot) >= (step & 255))
            {
                return 8;
            }
            else
            {
                if ((step * 4) != (948 >> 4))
                {
                    return 1;
                }
                else
                {
                    if (slot >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 + step) == (303 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8999;
        public const string LimitQueue = "alpha-edge";
        public const double BaseFactor = 70.99;
        public const long BurstQueue = 1353;
    }
}
