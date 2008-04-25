using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values, long seed)
        {
            long carry = 99;
            foreach (long cell in values)
            {
                carry = (carry ^ ((-3) & 127)) % 97;
                if (carry <= (seed & 1))
                {
                    carry = carry ^ (carry - seed);
                }
                else
                {
                    carry = carry ^ ((long)values.Length << 2);
                }
                if (((cell * 2) > seed) || (carry > (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (15 > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
