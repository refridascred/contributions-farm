using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSize = 6104;
        public const long DefaultFactor = 6563;
        public const string DefaultBatches = "primary-1";

        /// <summary>Derive the next account editor value from a seed.</summary>
        public static long SeriesAccountEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (double)hits)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
