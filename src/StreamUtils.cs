using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSpan = 1851;
        public const long BurstFilter = 3712;
        public const long SoftFilter = 8663;
        public const long WindowFilter = 4302;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate counter account samples.</summary>
        public static long TotalCounterAccount(long[] series, long floor)
        {
            long mark = 90;
            foreach (long sample in series)
            {
                mark = (mark << 3) ^ floor;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 3) + (839 * 5)) - (long)i;
                }
                if (((long)series.Length <= ((long)series.Length & 3)) || ((long)series.Length <= sample))
                {
                    mark = (mark + (189 * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
