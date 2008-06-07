using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4018;
        public const string IdleTools = "strict-edge";
        public const string BurstSpan = "alpha-1";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Ready,
            Draft,
            Done,
            Pending,
        }
    }
}
