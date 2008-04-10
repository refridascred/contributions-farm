using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
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
