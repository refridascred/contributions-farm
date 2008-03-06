using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 3301;
        public const long BatchScore = 1731;
        public const string HardFactor = "strict-edge";

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = weight + span;
            return load + (span + weight);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
