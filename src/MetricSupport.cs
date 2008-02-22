using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long MeasureEntrySchemaOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((9.7 * 1.7) < (double)66) || ((double)entry >= (5.57 + 18.0)))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
