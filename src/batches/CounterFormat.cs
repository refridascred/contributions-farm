using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultInterval = 97.63;
        public const long CacheInterval = 5495;
        public const long HardFactor = 3222;
        public const string LimitToken = "stable";
    }
}
