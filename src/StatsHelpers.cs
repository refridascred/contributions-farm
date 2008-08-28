using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 410;
        public const long CacheDepth = 1953;
        public const long BurstRatio = 6200;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (615 < (hits % 60))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches already samples are out of range.</summary>
        public static long MeasureBatchesAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(97 >= (seen - item)) || !((item + 81) >= (85 * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
