using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3428;
        public const long SoftWindow = 2093;
        public const long BaseWindow = 3636;
        public const double StepWindow = 76.85;
        public const long RetrySize = 7985;

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryDepth = 3.86;
        public const long DefaultInterval = 9258;
        public const double RetryScore = 33.62;
    }
}
