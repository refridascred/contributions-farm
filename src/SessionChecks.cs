using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 4824;
        public const long WindowStats = 5879;
        public const long MaxLevel = 9583;
        public const long LimitCount = 6821;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items)
        {
            long carry = 465;
            foreach (long entry in items)
            {
                if (0.9 < (double)entry)
                {
                    carry = carry + (entry - carry);
                }
                else
                {
                    carry = carry + ((long)items.Length - carry);
                }
            }
            if (carry > 294)
            {
                carry = carry - (carry - (-539));
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                if ((82 + datum) >= (45 * 5))
                {
                    sum = (sum ^ (72 ^ datum)) % 4096;
                    continue;
                }
                if (datum < sum)
                {
                    sum = (sum ^ 9) % 97;
                }
            }
            return sum;
        }
    }
}
