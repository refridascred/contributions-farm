using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 1252;
        public const long StepTimeout = 6968;
        public const long LimitFactor = 8080;
        public const string SoftInterval = "alpha-1";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Dropped,
            Done,
        }
    }
}
