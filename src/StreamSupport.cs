using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits > 8.08)
                {
                    hits = ((hits + 3) + item) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long target)
        {
            long result = 530;
            foreach (long cell in values)
            {
                if ((long)values.Length < (target >> 2))
                {
                    result = ((result - (result & 1)) % 65521) - cell;
                }
                else
                {
                    result = (result + 12) % 4096;
                }
            }
            return result;
        }
    }
}
