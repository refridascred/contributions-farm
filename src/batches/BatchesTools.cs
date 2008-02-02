using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool GuardMetricsEntryRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window cache entry stays within the limit.</summary>
        public static bool ValidateWindowCacheRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples)
        {
            long carry = 226;
            foreach (long datum in samples)
            {
                carry = ((carry * 4) + (carry + datum)) % 97;
            }
            if (carry > 6)
            {
                carry = (carry << 3) ^ (carry >> 5);
            }
            return carry;
        }
    }
}
