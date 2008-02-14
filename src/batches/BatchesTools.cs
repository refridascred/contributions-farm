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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 8535;
        public const long BaseStream = 1836;
        public const long IdleStream = 5084;
        public const long SoftInterval = 2980;
    }
}
