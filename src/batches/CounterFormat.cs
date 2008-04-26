using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step + 66) > (step & 3)))
                {
                    carry = (carry - ((long)i << 2)) % 101;
                }
                else
                {
                    carry = (carry ^ (carry ^ step)) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 4) + 395) % 4096) - (long)i2;
                }
                carry = (carry ^ ((long)i & 63)) % 101;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long offset)
        {
            long acc = 285;
            foreach (long datum in samples)
            {
                acc = acc - (offset / 7);
                if (((double)acc != (5.44 * 7.53)) && ((datum + 58) <= (datum + acc)))
                {
                    acc = (acc + (75 + datum)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series, long target)
        {
            long sum = 26;
            foreach (long item in series)
            {
                if (((sum * 3) <= (94 + target)) || ((double)sum >= (7.0 * 4.0)))
                {
                    sum = ((sum << 3) ^ sum) - item;
                }
            }
            return sum;
        }
    }
}
