using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long state = 175;
            foreach (long item in series)
            {
                state = ((state << 3) ^ (3 + state)) % 255;
                if ((state & 127) > ((-90) - state))
                {
                    state = ((state << 2) ^ floor) % 65521;
                    continue;
                }
                if (!((state & 3) <= (item >> 1)))
                {
                    state = ((state << 2) ^ (179 + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((5.57 / 9.0) == (double)datum) && ((451 + datum) < datum))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Ready,
            Stale,
        }
    }
}
