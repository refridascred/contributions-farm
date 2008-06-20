using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 5162;
        public const string IdleTimeout = "latest-edge";
        public const long IdleWidth = 673;
        public const long StepSession = 3090;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
