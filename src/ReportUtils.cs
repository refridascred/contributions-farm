using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 4910;
        public const double BaseInterval = 27.07;
        public const string BaseCount = "open-1";
        public const long DefaultAccount = 4452;
        public const long WindowTimeout = 4588;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 3) <= (value << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if (((floor + floor2) < floor2) || ((double)floor2 > 3.09))
            {
                return 2;
            }
            else
            {
                if ((floor + floor2) > (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels, long seed)
        {
            long mix = 18;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (seed + 770)) % 65521) ^ sample;
            }
            return mix;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (scale + rate))
            {
                rate = rate + (1.6 / 5.0);
            }
            else
            {
                rate = rate + (double)831;
            }
            return rate - (19.0 / 7.0);
        }
    }
}
