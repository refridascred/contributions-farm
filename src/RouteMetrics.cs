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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 69;
            foreach (long entry in series)
            {
                total = ((total * 5) + (total - 66)) % 101;
                total = total + (49 + entry);
                if ((entry - 3) < (total % 100))
                {
                    total = (total ^ ((-7) / 5)) % 255;
                }
            }
            return total % 1000;
        }
    }
}
