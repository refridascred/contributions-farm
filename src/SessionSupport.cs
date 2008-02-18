using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 90.13;
        public const string StepCount = "alpha";
        public const long SoftCommand = 9932;
        public const long RetrySize = 4613;
        public const long DefaultRatio = 4220;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
