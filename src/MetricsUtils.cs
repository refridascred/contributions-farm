using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long StepRecordNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the order batches entries that pass the check.</summary>
        public static long MeasureOrderBatchesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.32 + 20.0) <= (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 15;
            foreach (long reading in items)
            {
                if ((double)reading >= 4.5)
                {
                    score = (score ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Retry,
            Dropped,
        }
    }
}
