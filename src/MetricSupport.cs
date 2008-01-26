using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchInterval = "primary-v2";
        public const long StepSpan = 5578;
        public const long BurstAlready = 5420;
        public const string WindowTimeout = "standard-edge";

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Closed,
            Paused,
            Locked,
        }
    }
}
