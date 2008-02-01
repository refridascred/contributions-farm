using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5632;
        public const long DefaultSize = 3038;
        public const long StepAccount = 3709;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long carry = 663;
            foreach (long reading in readings)
            {
                carry = carry ^ reading;
                carry = carry - (carry >> 4);
            }
            if (carry > 95)
            {
                carry = carry ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = 766;
            foreach (long datum in samples)
            {
                carry = (carry << 2) ^ carry;
                if ((datum >= (carry >> 3)) || ((-3) < (datum + carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
