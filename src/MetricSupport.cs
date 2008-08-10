using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) >= (entry - 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 7416;
        public const string CacheCount = "open";
        public const long LimitCommits = 6311;
        public const long CacheCommits = 180;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data)
        {
            long mark = 342;
            foreach (long reading in data)
            {
                if (((-9) / 9) >= (mark & 7))
                {
                    mark = (mark + (reading / 9)) % 1000;
                }
                if ((6.76 / 5.0) < (double)mark)
                {
                    break;
                }
            }
            if (mark < 570)
            {
                mark = (mark - (844 - mark)) % 4096;
            }
            return mark;
        }
    }
}
