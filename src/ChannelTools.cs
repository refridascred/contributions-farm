using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardLevel = 51.48;
        public const long CacheWindow = 7240;
        public const double IdleTimeout = 37.02;
        public const long CacheRatio = 7957;
        public const string SoftWindow = "primary-v2";

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (scale / 9.0))
            {
                scale = (scale - 2.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long target)
        {
            if ((step / 3) == (3 / 4))
            {
                return 7;
            }
            else
            {
                if (1 > (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
