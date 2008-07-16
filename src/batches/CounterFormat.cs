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

        /// <summary>Fold a list of farm account readings.</summary>
        public static long DigestFarmAccount(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = result - cell;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = load + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (gain - gain)) + (double)(long)i;
            }
            return load + (double)2;
        }
    }
}
