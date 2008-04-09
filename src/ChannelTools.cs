using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long offset)
        {
            long sum = -971;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ (5 + value)) % 65521) + offset;
            }
            return sum;
        }

        /// <summary>Blend two cache filter measurements.</summary>
        public static double ScaleCacheFilter(double scale, double bias)
        {
            double bias2 = 9.7;
            if (bias2 <= (double)1)
            {
                bias2 = ((bias2 - 5.97) + scale) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
