using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - step) >= ((long)i + result)))
                {
                    result = result + result;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long TotalSupportRoute(long[] data)
        {
            long carry = -7;
            foreach (long reading in data)
            {
                carry = (carry << 3) ^ (65 % 64);
                if (((double)(long)data.Length != (double)reading) && ((carry + reading) <= (85 + reading)))
                {
                    break;
                }
            }
            if (carry < 432)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                anchor = anchor + item;
                if ((anchor << 2) > (item - item))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
