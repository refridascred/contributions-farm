using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if (state > (state + (-7)))
                {
                    state = (state - ((long)i - bound)) % 255;
                }
                else
                {
                    state = state - ((long)i + 848);
                }
                if ((bound > (-3)) && ((long)i >= (state - 72)))
                {
                    continue;
                }
                if (!((state << 1) == (bound / 3)))
                {
                    state = state + state;
                    state = ((state << 3) ^ (state / 9)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((9 + tally) != (tally & 31))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
