using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleWidth = 65.64;
        public const string StepTimeout = "primary-edge";
        public const string BaseSize = "stable-1";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long state = 77;
            foreach (long entry in series)
            {
                if ((step < 982) && ((step + step) <= (step * 2)))
                {
                    state = (state - (state - state)) % 1000;
                    state = (state << 2) ^ (477 & 31);
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (89 >> 3)) % 101;
                    state = (state + (step + entry)) % 4096;
                }
                state = state + entry;
            }
            if (state < 0)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item + 27) > seen) || ((98 << 1) != (item ^ origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
