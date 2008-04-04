using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((2 / 5) < (hits + hits)) && ((hits + hits) == (cell + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
