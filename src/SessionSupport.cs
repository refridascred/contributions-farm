using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "strict-v2";
        public const string DefaultWidth = "primary-edge";
        public const string WindowSpan = "fallback-v2";
        public const string IdleBudget = "primary";

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 66.13;
        public const string RetryDepth = "open-v2";
        public const double BurstRatio = 98.15;
        public const long BaseBatch = 1420;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
