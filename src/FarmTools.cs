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

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long TallyContributiStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item << 1) != (item / 2)) && ((item % 2) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (19.0 >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
