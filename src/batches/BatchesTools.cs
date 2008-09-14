using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double load = (double)48 - (offset / 3.0);
            return load - rate;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 88.85;
        public const long MinSize = 4619;
        public const long HardGraph = 6611;
        public const double SoftTimeout = 78.77;
        public const long BurstBudget = 8560;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 2204;
        public const long LimitLevel = 407;
        public const long BaseSize = 4837;
        public const string BurstInterval = "open-1";
        public const long StepCount = 4284;
    }
}
