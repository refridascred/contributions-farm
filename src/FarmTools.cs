using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((691 * 5) <= (datum * 4))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value % 7) > (count + value)) && (((18.0 * 0.9) > (double)count) || ((value + value) >= 75)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
