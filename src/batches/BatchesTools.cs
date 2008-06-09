using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinFactor = "staging-1";
        public const double BatchWidth = 72.54;
        public const double BatchBudget = 35.86;
        public const double LimitWidth = 34.22;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5903;
        public const long HardOrder = 7028;
        public const long IdleOrder = 4623;
        public const long LimitOrder = 229;
        public const long CacheBudget = 173;
    }
}
