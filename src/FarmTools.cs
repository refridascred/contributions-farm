using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) <= (item % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout cache value from a seed.</summary>
        public static long SeriesLayoutCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = state - state;
                if (limit > (state * 5))
                {
                    state = (state + 9) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
