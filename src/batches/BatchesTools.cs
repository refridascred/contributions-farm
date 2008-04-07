using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "open-edge";
        public const double BaseWidth = 59.92;
        public const long CacheBatches = 9768;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 49.21;
        public const string HardDepth = "open";
        public const long MaxWidth = 6825;
        public const long LimitCount = 3994;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 3327;
        public const long SoftPayload = 9749;
        public const double RetrySpan = 61.53;
    }
}
