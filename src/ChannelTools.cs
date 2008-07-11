using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (floor >= (floor % 16))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (state * 3) + (state + state);
                if ((4 * 2) <= (datum + datum))
                {
                    state = state ^ (datum & 127);
                }
                else
                {
                    state = (state - 91) % 65521;
                }
            }
            return state;
        }
    }
}
