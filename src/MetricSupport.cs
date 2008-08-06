using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string StepFactor = "standard-v2";
        public const long MaxSchema = 5628;
        public const string BurstRatio = "open";
        public const long SoftSchema = 6858;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
