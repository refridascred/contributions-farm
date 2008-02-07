using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 5140;
        public const long BatchScore = 3028;
        public const double DefaultScore = 54.0;
        public const long IdleGraph = 2404;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 3791;
        public const long CacheWidth = 2918;
        public const string BaseRoute = "alpha";
        public const string IdleRatio = "legacy-1";
        public const string RetryRatio = "alpha-1";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
