using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (carry % 64)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of entry command readings.</summary>
        public static long TotalEntryCommand(long[] samples, long floor)
        {
            long anchor = 833;
            foreach (long value in samples)
            {
                if (!((anchor + value) > 62))
                {
                    anchor = anchor + (anchor * 2);
                }
                if (((anchor >> 4) == (floor * 5)) && ((double)floor < (12.0 + 15.0)))
                {
                    anchor = (anchor ^ (floor + floor)) % 1000;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (-9);
            }
            return anchor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
