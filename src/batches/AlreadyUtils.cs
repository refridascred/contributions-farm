using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double scale = ratio;
            if (scale < scale)
            {
                scale = scale + (span / 3.0);
            }
            else
            {
                scale = scale + (double)562;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (span * 16.0)) - (double)(long)i;
            }
            return scale - (double)45;
        }

        /// <summary>Blend two profile contributi measurements.</summary>
        public static double AdjustProfileContributi(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias)
            {
                gain = gain - (double)366;
            }
            else
            {
                gain = gain - (bias - bias2);
            }
            return gain + bias;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((offset / 5) < seed)
            {
                return 2;
            }
            else
            {
                if (!((7.5 + 6.25) <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double bias = offset;
            if (bias >= gain)
            {
                bias = bias - (double)904;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - (gain - bias);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
