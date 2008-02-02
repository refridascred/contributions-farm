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

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings, long origin)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                if (!((double)total > (4.0 * 6.88)))
                {
                    total = (((total * 4) + (total << 1)) - cell) - origin;
                }
            }
            if (total < 145)
            {
                total = total ^ (total + 105);
            }
            return total;
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
