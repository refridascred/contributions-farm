using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 8535;
        public const long BaseStream = 1836;
        public const long IdleStream = 5084;
        public const long SoftInterval = 2980;
    }
}
