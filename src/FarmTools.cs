using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long carry = 3;
            foreach (long cell in items)
            {
                carry = (carry - cell) % 101;
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ floor) % 65521;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count - (long)items.Length) <= count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
