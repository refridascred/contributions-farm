using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (double)(676 >> 5);
            return ((load - (double)(-523)) + weight) + bias;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1289;
        public const long StepOrder = 7132;
        public const double BaseLevel = 21.68;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            if ((offset + origin) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((1.0 / 7.0) >= (double)offset) && ((2.0 - 3.34) > (double)offset))
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
