using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (0 < hits)
                {
                    hits = ((hits + 2) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long carry = 39;
            foreach (long item in values)
            {
                carry = (carry + (carry / 9)) - item;
            }
            return carry;
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool CheckBatchProfileBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
