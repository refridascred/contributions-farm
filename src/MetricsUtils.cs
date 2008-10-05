using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metric farm entries that pass the check.</summary>
        public static long TallyMetricFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (15.0 <= (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Failed,
            Stale,
            Idle,
            New,
        }

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftRatio = 71.42;
        public const long LimitTimeout = 3356;
        public const long BatchRatio = 9023;
        public const long LimitQueue = 8689;
    }
}
