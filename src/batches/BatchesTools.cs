using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 343;
        public const string RetryBudget = "stable";
        public const long StepScore = 4627;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 72.92;
        public const long MinScore = 2103;
        public const long RetryQueue = 267;
        public const string BaseQueue = "fallback-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}
