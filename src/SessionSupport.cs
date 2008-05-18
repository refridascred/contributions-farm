using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 34;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + anchor) - item;
            }
            if (anchor > 329)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long mix = 95;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (entry << 2)) - target;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long FoldFilterCommits(long[] items, long step)
        {
            long carry = 86;
            foreach (long reading in items)
            {
                carry = ((carry ^ (step << 2)) % 65521) + reading;
            }
            if (carry > 45)
            {
                carry = (carry << 3) ^ ((-4) >> 3);
            }
            return carry;
        }
    }
}
