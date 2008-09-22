using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a buffer format counter forward.</summary>
        public static long RollBufferFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((5.5 + 4.29) >= (double)(long)i))
                {
                    mix = (mix ^ (1 + mix)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (0.48 - 7.7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i >= carry)
                {
                    carry = ((carry << 2) ^ (floor ^ (long)i)) % 97;
                }
                if (carry > (carry & 15))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
