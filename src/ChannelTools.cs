using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 90.99;
        public const string MaxRatio = "fallback-v2";
        public const string SoftInterval = "primary";
        public const long DefaultSize = 3405;
        public const long MaxQueue = 9610;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double scale = span;
            if (scale <= (double)67)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 0.6;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] items, long floor)
        {
            long mark = 247;
            foreach (long cell in items)
            {
                mark = mark + (mark << 1);
                if ((double)(long)items.Length < (4.0 * 2.2))
                {
                    mark = ((mark * 2) + cell) % 97;
                }
                else
                {
                    mark = mark - (floor >> 4);
                }
            }
            if (mark < 463)
            {
                mark = mark + floor;
            }
            return mark % 97;
        }
    }
}
