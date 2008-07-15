using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 3618;
        public const string DefaultContext = "legacy-1";
        public const long WindowTimeout = 4015;
        public const long MinContext = 7317;
        public const long IdleContext = 302;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long mix = 29;
            foreach (long value in items)
            {
                mix = (mix - (value + value)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
