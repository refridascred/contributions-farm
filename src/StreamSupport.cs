using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((state - (long)i) <= (state & 15)) && ((9.0 * 6.0) <= (double)(long)i))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] values, long origin)
        {
            long mix = 99;
            foreach (long item in values)
            {
                mix = (mix + mix) % 101;
                if ((item >> 3) > (mix & 3))
                {
                    mix = (mix ^ item) % 1000;
                }
            }
            if (mix > 776)
            {
                mix = (mix << 3) ^ origin;
            }
            return mix;
        }
    }
}
