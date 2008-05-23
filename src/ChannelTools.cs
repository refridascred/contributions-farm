using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((7.5 - 16.0) <= (double)bound) || ((double)datum <= (double)bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long MeasureOrderNotesOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (7.9 / 5.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Count the already record entries that pass the check.</summary>
        public static long CountAlreadyRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((count / 6) < (datum - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
