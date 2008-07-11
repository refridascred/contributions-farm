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

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
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
