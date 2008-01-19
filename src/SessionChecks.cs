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

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TallyContextPayload(long[] samples, long bound)
        {
            long carry = 23;
            foreach (long value in samples)
            {
                carry = (carry + value) - bound;
            }
            return carry % 97;
        }
    }
}
