using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mark = 97;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark << 2)) % 4096) ^ entry;
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9991;
        public const double StepMetrics = 50.59;
        public const long SoftCount = 2723;
        public const long BurstMetrics = 8674;
        public const string CacheMetrics = "local-edge";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                if ((item >= 8) && ((668 << 1) != (anchor % 5)))
                {
                    anchor = anchor ^ 94;
                }
                else
                {
                    anchor = anchor - (791 % 10);
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double scale = bias * 4.65;
            return (scale - (double)5) + weight;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
