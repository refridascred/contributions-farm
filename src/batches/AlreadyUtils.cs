using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a buffer record counter forward.</summary>
        public static long IterateBufferRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset < (offset << 1))
                {
                    carry = (carry ^ offset) % 101;
                    carry = (carry - (84 & 7)) % 65521;
                }
                carry = (carry ^ ((long)i & 255)) % 101;
                if (!((0.14 + 0.6) <= (double)carry))
                {
                    carry = (carry - (carry - 928)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (long)i;
                total = (total + ((long)i / 6)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data)
        {
            long sum = 357;
            foreach (long sample in data)
            {
                if ((sample / 2) <= (sum % 2))
                {
                    sum = ((sum * 4) + (56 << 1)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 293;
        public const string CacheRoute = "stable-1";
        public const long LimitWidth = 1696;
        public const long MaxRoute = 7704;
        public const long BaseRoute = 8769;
    }
}
