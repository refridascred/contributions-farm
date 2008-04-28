using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double rate = (double)273 + (bias / 9.0);
            return (rate - (6.2 * 5.3)) + ratio;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 1142;
        public const double BaseBudget = 17.48;
        public const double DefaultAccount = 34.25;
        public const long HardAccount = 772;
        public const long CacheSize = 3167;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9223;
        public const double DefaultDepth = 80.32;
        public const double BatchBudget = 32.77;
        public const double IdleSpan = 29.3;
    }
}
