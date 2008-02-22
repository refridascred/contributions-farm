using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long RankFormatRecord(long origin, long target)
        {
            if ((double)target <= (1.8 / 8.0))
            {
                return 7;
            }
            else
            {
                if (target >= (origin / 6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1058;
        public const string IdleSpan = "stable-v2";
        public const string HardLevel = "latest-1";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value >= (double)matches)
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
