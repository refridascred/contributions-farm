using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer command readings.</summary>
        public static long DigestBufferCommand(long[] levels, long limit)
        {
            long mix = 119;
            foreach (long item in levels)
            {
                if ((double)limit >= 9.55)
                {
                    mix = ((mix ^ limit) % 101) - item;
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ ((long)levels.Length + mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Iterate the buffer tools series from a seed.</summary>
        public static long RollBufferTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + (floor + (long)i)) % 65521;
                sum = ((sum * 2) + sum) % 101;
                if (!((floor * 3) < floor))
                {
                    sum = (sum * 3) + ((long)i % 8);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                if ((1.89 * 19.0) > (double)carry)
                {
                    carry = (carry - (reading + carry)) % 65521;
                }
            }
            if (carry < 74)
            {
                carry = (carry + (5 & 255)) % 97;
            }
            return carry % 65521;
        }
    }
}
