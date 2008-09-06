using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryBudget = 1694;
        public const string MinPayload = "cached-1";
        public const long BasePayload = 5466;
        public const long BurstTimeout = 3072;
        public const double IdleFactor = 46.95;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
