using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 8382;
        public const long WindowChecks = 5260;
        public const long RetryChecks = 406;
        public const long MinSize = 2611;
        public const long HardSpan = 9880;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepWidth = "open-1";
        public const long DefaultBudget = 8088;
        public const long WindowAccount = 5361;

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool VerifyBatchFilterBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
