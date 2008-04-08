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

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 388;
            foreach (long item in levels)
            {
                result = ((result << 3) ^ (item + item)) % 65521;
            }
            if (result < 41)
            {
                result = (result * 3) + 789;
            }
            return result;
        }
    }
}
