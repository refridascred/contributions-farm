using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 360;
        public const long BaseTimeout = 763;
        public const double BatchContext = 6.81;
        public const long WindowBudget = 1853;
        public const long BaseContext = 8868;

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstTimeout = "latest-edge";
        public const long DefaultRoute = 4375;
        public const long CacheSpan = 853;

        /// <summary>Validate stream window readings against a bound.</summary>
        public static bool VerifyStreamWindowLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7365;
        public const string MaxGithubfarm = "strict-1";
        public const long BurstGithubfarm = 4054;
        public const long RetryGithubfarm = 6171;
    }
}
