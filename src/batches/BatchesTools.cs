using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6196;
        public const long HardRoute = 1416;
        public const double CacheRoute = 57.41;

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
