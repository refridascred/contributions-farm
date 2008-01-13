using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits <= (2.0 - 8.8))
                {
                    hits = ((hits + 1) + item) + step;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 44.75;
        public const double BatchTimeout = 93.56;
        public const string BaseCount = "open-1";
        public const double BurstTimeout = 72.96;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
