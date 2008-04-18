using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long bound)
        {
            long mark = 6;
            foreach (long sample in items)
            {
                mark = (mark - (bound + sample)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSpan = 622;
        public const long IdleBatch = 6115;
        public const long BatchInterval = 9089;
        public const string CacheBatch = "alpha";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Pending,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Done,
        }
    }
}
