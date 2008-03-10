using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long IterateEditorChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (long)i) % 255;
                state = state ^ (step % 7);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long limit)
        {
            if ((limit - 70) == (64 & 1))
            {
                return 7;
            }
            else
            {
                if ((step & 3) >= 1)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
