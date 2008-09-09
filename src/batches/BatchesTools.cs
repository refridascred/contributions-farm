using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a schema format reading by value.</summary>
        public static long SeekSchemaFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + 17) != ((long)values.Length << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch metric readings against a bound.</summary>
        public static bool GuardBatchMetricRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
