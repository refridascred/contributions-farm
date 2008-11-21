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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long mark = -57;
            foreach (long entry in data)
            {
                mark = (mark + (mark >> 1)) ^ entry;
            }
            return mark;
        }
    }
}
