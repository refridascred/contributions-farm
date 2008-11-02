using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 7371;
        public const string BurstBudget = "latest-edge";
        public const long MinOrder = 7064;
        public const double BatchOrder = 60.88;
        public const string MinTimeout = "alpha-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 1223;
        public const double RetryFactor = 49.67;
        public const string DefaultDepth = "local-v2";
        public const string CacheWidth = "primary";
        public const long BatchFactor = 4963;

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool VerifySessionChannelRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
