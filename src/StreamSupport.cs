using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseDepth = 78.25;
        public const long BurstStats = 9899;
        public const long SoftDepth = 8849;
        public const long LimitBudget = 5920;
        public const long SoftStats = 3082;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
