using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 55.36;
        public const long BasePayload = 2746;
        public const long IdleInterval = 6071;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 8232;
        public const long RetryStream = 4622;
        public const long StepStream = 3533;
    }
}
