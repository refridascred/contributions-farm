using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long offset2)
        {
            if (offset2 >= (offset / 7))
            {
                return 1;
            }
            else
            {
                if ((offset2 << 1) < offset2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 38) != (reading / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)seed >= (19.0 + 9.5))
                {
                    carry = carry ^ (seed & 3);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
