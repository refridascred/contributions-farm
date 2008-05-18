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

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + ((long)i / 4);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
