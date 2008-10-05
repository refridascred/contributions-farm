using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 4997;
        public const double RetryChannel = 26.99;
        public const long CacheChannel = 7422;
        public const double DefaultSpan = 98.53;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Ready,
            Closed,
            Stale,
            Queued,
        }
    }
}
