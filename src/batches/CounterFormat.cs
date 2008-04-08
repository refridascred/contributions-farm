using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double mean = 9.64 - weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)157;
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
