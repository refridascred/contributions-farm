using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 97.03;
        public const long HardRatio = 4930;
        public const long CacheLevel = 9475;
        public const long HardCount = 6461;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long AuditEditorMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)reading < (2.1 - 2.61)) || ((hits % 24) < (255 << 1))) || ((reading + 6) > (reading % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long limit)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                if (limit < (mix * 2))
                {
                    mix = ((mix << 2) ^ 38) % 4096;
                    continue;
                }
                mix = (mix << 3) ^ (mix + mix);
                if (limit >= (entry % 3))
                {
                    mix = ((mix << 3) ^ (mix + (long)series.Length)) % 255;
                }
            }
            return mix;
        }
    }
}
