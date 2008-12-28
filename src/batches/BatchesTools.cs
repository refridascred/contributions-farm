using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (bound < (count + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >> 2) >= (item ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
