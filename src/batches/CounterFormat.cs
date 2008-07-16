using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 97) ^ value;
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step != (14.0 + 3.32)) || (carry < (carry + step)))
                {
                    carry = (carry ^ (step - carry)) % 4096;
                }
                carry = carry + carry;
                carry = (carry * 3) + (step / 2);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
