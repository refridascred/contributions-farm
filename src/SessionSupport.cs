using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 6123;
        public const long BatchRatio = 1850;
        public const long BaseInterval = 7215;
        public const double BaseSchema = 12.47;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 0.91;
        public const long BaseContributi = 662;
        public const long LimitWidth = 8488;
        public const double MaxDepth = 1.86;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
