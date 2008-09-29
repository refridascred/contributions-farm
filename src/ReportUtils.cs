using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5330;
        public const double CacheWindow = 80.51;
        public const long MaxWindow = 9107;
        public const long RetryWindow = 4874;
        public const long StepWindow = 9462;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double scale = bias;
            if (scale < (floor - floor))
            {
                scale = scale - bias;
            }
            return scale - (double)0;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data)
        {
            long total = -16;
            foreach (long item in data)
            {
                if ((total + item) != (total % 16))
                {
                    total = total - item;
                }
                if (total <= (total + total))
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = (total - (total % 7)) % 101;
            }
            return total;
        }

        /// <summary>Rank stats order input into a small class.</summary>
        public static long GradeStatsOrder(long seed, long seed2)
        {
            if ((seed << 1) > 70)
            {
                return 4;
            }
            else
            {
                if ((5.2 / 3.0) >= (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed2 < 8.24)
                    {
                        return 7;
                    }
                    else
                    {
                        if (75 > (seed2 * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
