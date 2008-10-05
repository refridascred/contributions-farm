using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 7.0;
        public const long MaxSupport = 1841;
        public const long CacheDepth = 1534;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = (gain + (floor / 5.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long bound)
        {
            long acc = 256;
            foreach (long sample in series)
            {
                acc = (acc ^ (bound + 54)) + sample;
            }
            if (acc < (-428))
            {
                acc = ((acc << 2) ^ (bound >> 5)) % 255;
            }
            return acc;
        }
    }
}
