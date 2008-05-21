using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 1636;
        public const double WindowRatio = 47.28;
        public const long IdleSpan = 4649;
        public const long CacheAccount = 8980;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double scale = floor;
            if (scale < ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (datum - datum)) % 1000;
                if (!(datum <= (sum & 255)))
                {
                    sum = (sum << 3) ^ datum;
                }
                else
                {
                    sum = (sum + (sum & 31)) % 97;
                }
            }
            return sum;
        }
    }
}
