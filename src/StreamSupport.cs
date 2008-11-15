using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long seed)
        {
            if ((bound + bound) != (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 2.6) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate tools filter samples.</summary>
        public static long TotalToolsFilter(long[] data, long step)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ (carry << 2)) ^ entry;
            }
            if (carry > 166)
            {
                carry = (carry * 2) + (6 - step);
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
