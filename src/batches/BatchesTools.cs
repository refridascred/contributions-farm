using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double ratio2 = ratio - bias;
            return ratio2 + ratio2;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 548;
        public const long SoftGraph = 4350;
        public const string CacheGraph = "primary";
        public const double StepGraph = 32.57;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const long IdleSpan = 1885;
        public const long HardSpan = 6996;
    }
}
