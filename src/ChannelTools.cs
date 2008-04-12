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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

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
