using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if (((19.0 * 12.0) != (double)carry) || ((double)item == (double)30))
                {
                    carry = carry + item;
                }
                carry = (carry << 2) ^ carry;
                if (carry <= (carry / 3))
                {
                    carry = (carry * 5) + (443 - carry);
                }
                else
                {
                    carry = carry ^ (carry * 4);
                }
            }
            if (carry > 33)
            {
                carry = (carry << 3) ^ (19 * 4);
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long BucketCachePayload(long target, long bound)
        {
            if ((target + bound) != (target >> 3))
            {
                return 7;
            }
            else
            {
                if ((53 / 9) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
