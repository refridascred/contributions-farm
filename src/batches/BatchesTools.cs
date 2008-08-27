using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (9.8 >= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TotalCacheContext(long[] samples, long bound)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((value & 255) >= (result * 2))
                {
                    result = ((result + (result - 7)) % 255) - bound;
                }
            }
            return result;
        }
    }
}
