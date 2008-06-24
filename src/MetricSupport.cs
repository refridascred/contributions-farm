using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4002;
        public const double WindowCount = 53.97;
        public const long BurstSchema = 5214;
        public const long BaseInterval = 9155;

        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long MeasureSchemaReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) == (0 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
