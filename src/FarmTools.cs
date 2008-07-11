using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length == (hits << 3)) || (origin <= (6 ^ origin)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((4.86 * 8.14) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long limit)
        {
            long acc = 908;
            foreach (long item in items)
            {
                acc = ((acc ^ limit) % 101) - item;
            }
            return acc % 1000;
        }
    }
}
