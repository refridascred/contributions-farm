using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of already session readings.</summary>
        public static long FoldAlreadySession(long[] levels, long offset)
        {
            long total = 471;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > (offset + 11))
                {
                    total = ((total * 4) + total) + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long origin)
        {
            long gap = seed + origin;
            if (origin > 199)
            {
                return 8;
            }
            else
            {
                if ((origin > (gap - origin)) || ((2.1 - 1.2) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7868;
        public const string CacheFactor = "cached-v2";
        public const double BatchSize = 86.5;
        public const double HardSpan = 1.32;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (offset > (count ^ offset))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
