using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((463 / 8) <= hits)
                {
                    hits = ((hits + 3) + sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long offset)
        {
            long sum = 240;
            foreach (long datum in readings)
            {
                if ((169 & 255) != (sum & 15))
                {
                    sum = ((sum + (datum % 60)) % 101) - offset;
                }
            }
            if (sum > 231)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Idle,
            Failed,
            Retry,
        }
    }
}
