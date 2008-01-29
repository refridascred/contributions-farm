using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch metric entries that pass the check.</summary>
        public static long AuditBatchMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)sample < (4.0 - 16.0)) || (matches >= (matches - sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values)
        {
            long score = 71;
            foreach (long cell in values)
            {
                score = (score + (score / 5)) + cell;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits < entry) || ((13.0 <= (double)hits) || (4.59 >= (double)entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
