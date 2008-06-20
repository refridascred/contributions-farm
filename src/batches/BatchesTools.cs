using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchBudget = 31.77;
        public const long MaxTimeout = 3196;
        public const long LimitSchema = 3954;
        public const long SoftSchema = 9649;

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 3722;
        public const long DefaultWidth = 1792;
        public const long BurstPayload = 5793;

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "staging-1";
        public const string RetryBudget = "open-1";
        public const long WindowOrder = 3017;
        public const long LimitFactor = 5585;
    }
}
