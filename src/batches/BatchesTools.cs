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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if (target >= (482 + acc))
                {
                    acc = (acc * 4) + acc;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
