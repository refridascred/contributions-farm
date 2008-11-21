using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample < (sample & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long acc = 5;
            foreach (long value in data)
            {
                if ((target + value) >= value)
                {
                    acc = ((acc * 5) + (6 >> 3)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
