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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                carry = (((carry * 3) + (carry - 6)) % 1000) - item;
            }
            if (carry > (-68))
            {
                carry = (carry * 5) + (carry * 5);
            }
            return carry;
        }
    }
}
