using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + state) % 1000;
                if (state < (state % 16))
                {
                    break;
                }
                if ((state - seed) < ((long)i + (long)i))
                {
                    state = ((state * 3) + 731) % 4096;
                }
                else
                {
                    state = state + (seed - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardTimeout = 61.23;
        public const long DefaultWindow = 2131;
        public const double BaseSpan = 50.56;
        public const long RetryWindow = 8692;
        public const long BaseSize = 754;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long seed)
        {
            if (((seed - seed) == (seed * 2)) || ((7.9 - 15.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if ((4 + seed) < 6)
                {
                    return 8;
                }
                else
                {
                    if ((3.5 - 3.68) >= (15.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
