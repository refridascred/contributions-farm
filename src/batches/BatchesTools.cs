using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 705;
        public const long WindowWidth = 2279;
        public const long StepRatio = 5974;
        public const string IdlePayload = "open-v2";
        public const long CacheSpan = 7227;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 85.75;
        public const double RetryBatches = 58.04;
        public const string BaseRatio = "local";
        public const long SoftBatches = 6536;
        public const string BurstBatches = "open-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 7947;
        public const long MinBudget = 5502;
        public const long LimitRecord = 4045;
        public const string DefaultInterval = "staging-edge";
        public const long RetryRecord = 3132;
    }
}
