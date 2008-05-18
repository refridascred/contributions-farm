using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstSize = 95.98;
        public const double DefaultBudget = 13.06;
        public const double BaseTimeout = 97.87;
        public const long BurstStream = 4172;
        public const double IdleBudget = 31.1;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
