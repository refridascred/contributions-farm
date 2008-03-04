using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = carry;
                carry = (carry + (carry ^ next)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long target)
        {
            long mark = 61;
            foreach (long item in items)
            {
                mark = ((((mark << 3) ^ mark) % 97) + item) + target;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long bound)
        {
            if ((-5) <= bound)
            {
                return 3;
            }
            else
            {
                if ((192 ^ origin) == (origin - origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
