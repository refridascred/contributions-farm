using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cache route readings.</summary>
        public static long ScoreCacheRoute(long[] samples)
        {
            long acc = 45;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 4096;
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Synced,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((6.0 + 8.0) <= (double)entry)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
