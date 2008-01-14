using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "open";
        public const double SoftBudget = 21.99;
        public const long StepSize = 8785;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
