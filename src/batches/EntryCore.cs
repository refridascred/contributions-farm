using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((step + anchor) >= anchor))
                {
                    anchor = anchor + (step + (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
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
