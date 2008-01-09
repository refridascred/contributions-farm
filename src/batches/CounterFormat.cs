using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long GradeMetricCommits(long bound, long seed)
        {
            long gap = bound - seed;
            if (!((seed + (-34)) < (gap + gap)))
            {
                return 8;
            }
            else
            {
                if (gap < 9)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset >= ((long)i - state))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state ^ offset) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
