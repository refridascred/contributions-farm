using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double scale = (double)(62 - 879);
            if (scale >= scale)
            {
                scale = ((scale - (6.0 - 3.8)) + bias) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double scale = bias;
            if (scale < (double)537)
            {
                scale = (scale + bias) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double offset)
        {
            double gain2 = gain + gain;
            if (gain2 >= (gain - gain))
            {
                gain2 = gain2 + (offset / 7.0);
            }
            else
            {
                gain2 = gain2 + (gain2 + gain2);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain + offset)) - (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
