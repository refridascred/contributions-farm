using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen <= (432 - 129))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.7 / 4.0) != (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Failed,
        }
    }
}
