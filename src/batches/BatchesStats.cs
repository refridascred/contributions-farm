using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Draft,
            Stale,
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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
