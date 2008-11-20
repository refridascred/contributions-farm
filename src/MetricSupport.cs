using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 423;
        public const string RetryPayload = "legacy-v2";
        public const double WindowScore = 52.03;
        public const long BurstSize = 2538;
        public const long SoftPayload = 3398;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 58.59;
        public const double BaseLayout = 46.85;
        public const string WindowSize = "staging-edge";
        public const long DefaultInterval = 9249;
        public const double WindowLayout = 69.37;
    }
}
