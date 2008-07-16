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

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items)
        {
            long carry = 956;
            foreach (long cell in items)
            {
                if (((6.6 / 4.0) != (double)cell) && ((cell + 722) < (carry >> 4)))
                {
                    carry = ((carry * 3) + (cell / 8)) % 65521;
                }
            }
            return carry;
        }
    }
}
