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

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double load = (ratio + 4.3) + (ratio + ratio);
            if (load <= (double)5)
            {
                load = (load - (load - load)) - span;
            }
            return load + 6.1;
        }
    }
}
