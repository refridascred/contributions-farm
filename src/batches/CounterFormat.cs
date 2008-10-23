using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            if ((floor <= (floor + (-570))) && ((seed % 16) > 1))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (7.2 - 1.0))
                {
                    return 8;
                }
                else
                {
                    if ((floor & 3) <= (5 >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long StepChannelFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (seed * 4);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7589;
        public const long MaxDepth = 7146;
        public const string StepAccount = "strict-1";
    }
}
