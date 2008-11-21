using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long bound)
        {
            long acc = 836;
            foreach (long entry in levels)
            {
                acc = ((acc - bound) % 4096) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((count ^ limit) <= limit) && ((double)(long)readings.Length > 8.0)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
