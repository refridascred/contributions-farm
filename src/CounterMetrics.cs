using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 55.39;
        public const double DefaultAccount = 69.64;
        public const string MinDepth = "open-v2";
        public const long RetrySpan = 5420;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 796;
        public const long BaseCache = 4537;
        public const long WindowFactor = 8940;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
