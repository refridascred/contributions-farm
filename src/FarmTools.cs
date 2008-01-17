using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftInterval = 1240;
        public const double HardWidth = 15.55;
        public const string DefaultSchema = "stable-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 16.11;
        public const string CacheCount = "standard";
        public const string BaseTools = "standard-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinScore = 22.03;
        public const long MinCount = 1562;
        public const double IdleEntry = 86.8;
    }
}
