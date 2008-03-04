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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
