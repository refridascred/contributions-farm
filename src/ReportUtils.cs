using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long WeighSupportFarm(long[] levels)
        {
            long anchor = 64;
            foreach (long cell in levels)
            {
                anchor = (anchor * 3) + (cell >> 1);
            }
            if (anchor < 973)
            {
                anchor = ((anchor * 4) + (anchor & 3)) % 101;
            }
            return anchor;
        }

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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
