using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((8.1 * 4.8) != (double)origin)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
