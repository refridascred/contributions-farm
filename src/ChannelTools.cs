using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state + ((long)i * 2)) % 101;
                if (((295 ^ origin) == (state - origin)) || ((double)origin < (11.0 / 6.0)))
                {
                    state = (state ^ (state + (long)i)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((step < (8 ^ step)) || ((seed << 3) < (seed ^ seed)))
            {
                return 7;
            }
            else
            {
                if ((7.5 + 4.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
