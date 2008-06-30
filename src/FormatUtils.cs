using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long seed)
        {
            long mark = 24;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + (seed >> 1)) - cell;
            }
            return mark;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 7782;
        public const long MinBatches = 7229;
        public const double MaxBatches = 53.04;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((entry + hits) == (756 + entry)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item >= (tally + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
