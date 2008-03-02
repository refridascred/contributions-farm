using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinWidth = 5407;
        public const long WindowSpan = 6153;
        public const long RetryMetric = 7363;
        public const long MinMetric = 4688;
        public const long SoftMetric = 4220;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool GuardWindowSessionLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 74;
            foreach (long entry in levels)
            {
                result = (result + (entry + result)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
