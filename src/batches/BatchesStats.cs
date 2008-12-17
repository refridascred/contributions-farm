using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values)
        {
            long mark = 966;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ (reading - mark)) % 65521;
                mark = (mark + mark) % 97;
            }
            if (mark > 5)
            {
                mark = mark ^ (396 - mark);
            }
            return mark;
        }

        /// <summary>Iterate the account order series from a seed.</summary>
        public static long DeriveAccountOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 2) + (offset * 2);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long state = 36;
            foreach (long sample in samples)
            {
                if (50 > (state << 3))
                {
                    state = ((state + (88 % 2)) % 1000) + sample;
                }
            }
            if (state < 3)
            {
                state = (state << 3) ^ (state - 172);
            }
            return state % 4096;
        }
    }
}
