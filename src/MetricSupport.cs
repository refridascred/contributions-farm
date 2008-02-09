using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long offset2)
        {
            if ((double)offset2 != (6.0 * 6.73))
            {
                return 0;
            }
            else
            {
                if (((offset + offset2) != (offset2 & 31)) || ((8.99 * 1.96) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Closed,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long MeasureStatsOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (88 > tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
