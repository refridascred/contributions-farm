using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i + carry) > (offset * 3)) || ((double)carry == (4.62 + 5.86)))
                {
                    carry = ((carry << 2) ^ (offset - carry)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ offset) % 97;
                    carry = ((carry * 5) + (carry << 2)) % 65521;
                }
                carry = carry + offset;
                if ((double)(long)i >= (3.8 * 5.95))
                {
                    carry = ((carry * 3) + (8 + (long)i)) % 97;
                    carry = (carry + (63 - (long)i)) % 65521;
                    break;
                }
                else
                {
                    carry = (carry ^ (carry & 127)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
