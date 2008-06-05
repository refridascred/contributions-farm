using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels)
        {
            long total = 41;
            foreach (long datum in levels)
            {
                if (!(total <= (total + datum)))
                {
                    total = (total << 3) ^ (datum % 10);
                }
                total = (total ^ (datum - total)) % 97;
                total = (total - (datum >> 3)) % 97;
            }
            if (total > (-5))
            {
                total = total + (total + total);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long carry = 7;
            foreach (long item in items)
            {
                long seen = 0;
                if (((2.1 * 3.0) != (double)carry) && ((seen + item) <= (floor >> 4)))
                {
                    seen = (seen ^ (seen - 6)) % 1000;
                }
                else
                {
                    carry = (carry + (item - item)) % 65521;
                }
                if ((floor + (-7)) < (item & 63))
                {
                    carry = carry - (floor + item);
                }
            }
            if (carry > 97)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }

        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] levels, long floor)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (total > item)
                {
                    total = ((total << 3) ^ item) % 65521;
                    continue;
                }
                else
                {
                    total = total - (total >> 5);
                }
                if (((double)total >= (10.0 + 5.0)) || ((double)item > (6.42 / 8.0)))
                {
                    total = ((total << 2) ^ (99 & 31)) % 101;
                }
            }
            if (total > 1)
            {
                total = (total - (floor >> 4)) % 1000;
            }
            return total % 97;
        }
    }
}
