using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long AuditCommitsRouteGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (4.2 - 9.97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry ^ entry) > (entry & 31)) || ((574 > entry) && (((long)data.Length + entry) >= entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long limit)
        {
            long state = 5;
            foreach (long cell in levels)
            {
                if ((7.34 * 0.84) < (double)limit)
                {
                    state = (((state * 3) + (state ^ (-94))) % 4096) - cell;
                }
            }
            if (state > 947)
            {
                state = (state + (limit + limit)) % 101;
            }
            return state % 97;
        }
    }
}
