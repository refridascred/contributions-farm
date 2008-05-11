using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 2419;
        public const long BurstBudget = 2024;
        public const long WindowGraph = 5843;
    }
}
