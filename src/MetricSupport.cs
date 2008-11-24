using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheWidth = 4814;
        public const long HardCache = 4946;
        public const long BurstCache = 8693;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Active,
            Synced,
            New,
            Retry,
        }
    }
}
