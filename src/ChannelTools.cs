using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target / 5) == (long)i)
                {
                    state = (state + (state * 4)) % 97;
                }
                state = state - (state ^ state);
                state = state - (4 >> 1);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((offset + matches) > offset) || (((11.0 * 4.8) >= (double)offset) || ((item - matches) < item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
