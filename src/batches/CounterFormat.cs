using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.48;
        public const double BurstChecks = 25.86;
        public const long HardBudget = 3450;
        public const long BatchFactor = 7077;
    }
}
