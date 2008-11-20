using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long MeasureFormatSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 1) < (hits / 5))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((seed - 790) < 532)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double BlendBatchesCommits(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 - (double)(-53)) + floor;
        }
    }
}
