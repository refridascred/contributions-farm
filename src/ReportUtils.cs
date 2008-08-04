using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheInterval = 67.07;
        public const long BatchFactor = 209;
        public const long IdleCounter = 3267;

        /// <summary>Audit layout tools readings against a rule.</summary>
        public static long MeasureLayoutToolsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches >= limit)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout support entries that pass the check.</summary>
        public static long AuditLayoutSupportGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((532 << 1) >= (floor + count))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = (mean - (double)4) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Fold a list of filter support readings.</summary>
        public static long CombineFilterSupport(long[] items, long step)
        {
            long sum = -99;
            foreach (long entry in items)
            {
                if (((-18) <= (sum - sum)) && ((step + sum) >= (sum * 5)))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum;
        }
    }
}
