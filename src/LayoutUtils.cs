using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double drift = gain / 5.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)363) + (double)(long)i) + offset;
            }
            return drift - (drift - 6.2);
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long diff = step - seed;
            if ((364 << 2) <= seed)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (85 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((diff & 7) <= (diff * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
