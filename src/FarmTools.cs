using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long seed)
        {
            long lane = offset - seed;
            if (((seed / 2) <= offset) || ((seed + (-72)) == (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if ((lane + 824) > (seed * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 51.18;
        public const long IdleBudget = 6257;
        public const long LimitChecks = 4099;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if (state >= (origin * 3))
                {
                    state = ((state * 2) + state) % 1000;
                }
                if (!((-862) >= ((long)i & 255)))
                {
                    state = (state + (origin / 3)) % 101;
                    state = (state + origin) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
