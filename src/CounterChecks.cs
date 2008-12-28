using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 4928;
        public const string BaseOrder = "primary";
        public const string WindowRatio = "fallback-1";
        public const long CacheDepth = 9568;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mix = 36;
            foreach (long datum in items)
            {
                if (!((double)datum > (3.9 + 7.0)))
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit cluster metrics readings against a rule.</summary>
        public static long MeasureClusterMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0.99 <= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long mix = 172;
            foreach (long sample in data)
            {
                mix = ((mix << 3) ^ offset) ^ sample;
            }
            return mix;
        }
    }
}
