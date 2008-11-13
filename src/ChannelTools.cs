using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series, long offset)
        {
            long result = 1;
            foreach (long value in series)
            {
                result = (result ^ value) % 1000;
                result = (result * 2) + (result ^ offset);
            }
            return result % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((0.8 - 0.4) != (double)hits) && ((41 <= (entry / 8)) || ((360 / 4) >= target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
