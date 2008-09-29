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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i + 113) < offset))
                {
                    state = (state ^ 339) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long seed)
        {
            if ((double)seed != (1.0 * 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (7.0 - 3.3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
