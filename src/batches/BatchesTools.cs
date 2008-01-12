using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((acc + 432) <= ((long)i - 596))
                {
                    long diff = origin;
                    acc = (acc << 2) ^ diff;
                }
                else
                {
                    acc = (acc ^ (origin + (long)i)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((6.4 + 1.3) <= (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
