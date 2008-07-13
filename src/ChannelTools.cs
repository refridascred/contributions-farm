using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long state = 792;
            foreach (long sample in levels)
            {
                state = (state - sample) + origin;
            }
            return state;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((bound * 4) >= (limit << 1))
            {
                return 3;
            }
            else
            {
                if ((8 + limit) < (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (((limit >> 3) < (4 - 72)) && ((double)bound <= (19.0 * 2.51)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen % 97) >= (item & 31)) && ((992 < (item << 2)) && ((double)seen >= (double)item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
