using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - ((long)i - step);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long CombineWindowCommits(long[] data)
        {
            long state = 3;
            foreach (long datum in data)
            {
                if ((1.0 * 9.35) == (double)datum)
                {
                    state = ((state * 2) + (datum % 10)) % 1000;
                    state = (state + (state - 444)) % 1000;
                }
                if (((58 % 3) > datum) || ((631 - datum) <= state))
                {
                    state = state - (state + state);
                }
            }
            return state % 97;
        }
    }
}
