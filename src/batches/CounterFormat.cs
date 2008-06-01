using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            New,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double weight = rate;
            return (weight + weight) + offset;
        }
    }
}
