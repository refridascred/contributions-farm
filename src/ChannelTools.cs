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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long bound)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if (((bound - datum) <= (total - datum)) || ((double)datum <= (6.65 / 5.0)))
                {
                    total = (total - (datum >> 5)) % 101;
                }
            }
            return total;
        }
    }
}
