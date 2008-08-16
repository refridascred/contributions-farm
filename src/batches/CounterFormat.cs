using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (step <= (step - step))
                {
                    carry = (carry * 2) + (carry - 92);
                }
                carry = (carry + (5 >> 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (acc - (long)i);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long offset)
        {
            if ((offset > (target << 1)) || (3.39 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset - target) < ((-11) * 2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
