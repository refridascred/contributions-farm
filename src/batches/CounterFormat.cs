using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long DeriveSchemaSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if (mark > (mark << 3))
                {
                    mark = (mark + 706) % 1000;
                }
                mark = (mark + mark) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long limit)
        {
            long carry = 93;
            foreach (long entry in data)
            {
                carry = ((carry + carry) % 4096) - entry;
                if ((35 % 3) == (carry - limit))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long bound)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if ((acc * 2) <= (item + bound))
                {
                    acc = acc ^ (bound % 16);
                }
                else
                {
                    acc = (acc * 5) + (bound + item);
                }
            }
            return acc;
        }
    }
}
