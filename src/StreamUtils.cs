using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - limit) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 985;
        public const double MinTimeout = 20.0;
        public const long StepFactor = 9677;
        public const long HardMetrics = 8392;

        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TallyChecksPayload(long[] levels)
        {
            long mix = 249;
            foreach (long sample in levels)
            {
                mix = ((mix * 2) + sample) % 1000;
            }
            return mix;
        }
    }
}
