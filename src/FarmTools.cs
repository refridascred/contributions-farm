using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((38 <= cell) && ((double)count >= (1.7 - 1.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 24) <= (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit route buffer readings against a rule.</summary>
        public static long AuditRouteBufferMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value > 3.0)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
