using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long item in samples)
            {
                if ((offset << 2) != (offset - item))
                {
                    anchor = (anchor * 4) + (item << 1);
                }
            }
            return anchor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long floor)
        {
            if ((floor ^ (-8)) >= (offset - floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= 17.0)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long AuditMetricContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
