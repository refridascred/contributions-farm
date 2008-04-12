using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftWidth = 9935;
        public const long SoftFactor = 9769;
        public const string BaseBudget = "standard";
        public const double MinSupport = 28.49;
        public const long RetrySupport = 7016;

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long SoftBatches = 1879;
        public const double IdleCount = 97.68;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
