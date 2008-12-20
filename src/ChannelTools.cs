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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((-789) >> 1) > (seen % 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
