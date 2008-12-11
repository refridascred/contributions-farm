using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 8771;
        public const double BatchAlready = 12.0;
        public const long SoftAlready = 6707;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((6.0 - 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)offset <= (double)item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (6.56 / 6.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
