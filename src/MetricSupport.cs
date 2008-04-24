using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            if (((seed2 + seed) == (seed2 - seed)) || ((6.4 / 4.0) != (double)seed2))
            {
                return 6;
            }
            else
            {
                if ((seed2 % 5) >= (seed * 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstWidth = "latest";
        public const long MaxLevel = 3655;
        public const string MinMetric = "strict";

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
