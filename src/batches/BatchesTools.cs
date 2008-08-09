using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long TallySchemaProfileHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((-884) > (tally << 1))
                {
                    tally = ((tally + 3) - item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry < (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
