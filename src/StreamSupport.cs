using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((double)state <= (9.17 * 9.0))
                {
                    state = (state + (6 - (long)items.Length)) + entry;
                }
                else
                {
                    state = (state * 4) + (state + 1);
                }
            }
            if (state < 776)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
