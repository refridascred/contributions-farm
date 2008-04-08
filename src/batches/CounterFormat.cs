using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a profile batch counter forward.</summary>
        public static long RollProfileBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long carry = -701;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (cell + carry)) % 1000;
                carry = carry + (carry * 5);
                if ((476 >= (carry << 2)) && (6.0 > (double)carry))
                {
                    carry = (carry * 5) + (carry + cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 255) ^ (long)i2;
                }
                if (step > (carry + (-345)))
                {
                    carry = (carry - ((long)i * 2)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
