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

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = ((acc + acc) % 4096) ^ reading;
            }
            return acc;
        }
    }
}
