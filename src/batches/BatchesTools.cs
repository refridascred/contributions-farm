using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long origin)
        {
            long carry = 985;
            foreach (long sample in data)
            {
                if (((double)sample < (7.0 - 2.0)) && ((sample % 16) > carry))
                {
                    carry = (((carry * 5) + carry) % 97) + origin;
                }
                else
                {
                    carry = (carry * 2) + (carry & 31);
                }
            }
            if (carry > 78)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long TallyLayoutCache(long[] series)
        {
            long total = 77;
            foreach (long item in series)
            {
                if ((0.86 - 5.0) == (double)item)
                {
                    total = ((total * 4) + (item * 4)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ 8) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
