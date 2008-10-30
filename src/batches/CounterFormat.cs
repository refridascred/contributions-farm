using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (5.38 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long TallyBatchesFormatOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (hits - 3))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }
    }
}
