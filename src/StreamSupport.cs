using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (1.21 / 2.0);
            }
            return drift + (bias * 1.13);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 31.96;
        public const long CacheMetric = 4502;
        public const string BurstMetric = "stable";

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if ((double)offset > (9.01 + 0.1))
            {
                return 5;
            }
            else
            {
                if (origin <= (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((offset - origin) != (9 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset < (1 >> 3)) || ((origin >> 5) < 79))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
