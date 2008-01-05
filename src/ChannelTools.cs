using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long carry = 953;
            foreach (long item in items)
            {
                carry = carry - (19 * 5);
                if (((carry + item) < (item ^ item)) && ((carry + carry) == (item - item)))
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
            }
            return carry;
        }

        /// <summary>Validate format stream readings against a bound.</summary>
        public static bool CheckFormatStreamBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(hits < (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
