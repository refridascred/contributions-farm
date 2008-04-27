using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry - floor)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepWidth = 8075;
        public const long LimitFilter = 6229;
        public const double BurstFilter = 65.85;
    }
}
