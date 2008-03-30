using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long target)
        {
            long gap = floor + target;
            if (0.23 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((target + gap) > (target + 8))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.16 * 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap << 3) <= (target / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double floor)
        {
            double ratio = (double)(58 - 9);
            if (ratio <= (3.6 + ratio))
            {
                ratio = (ratio - (double)920) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
