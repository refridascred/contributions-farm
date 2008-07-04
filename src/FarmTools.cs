using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state + 719) % 97;
                if ((state - floor) > (state / 8))
                {
                    state = state - (long)i;
                    break;
                }
                if (((state % 16) != ((long)i / 7)) && ((5.16 / 9.0) >= (double)floor))
                {
                    state = state + (long)i;
                    break;
                }
                else
                {
                    state = state + (0 / 3);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
