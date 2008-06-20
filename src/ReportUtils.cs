using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSize = 1155;
        public const string StepWidth = "primary-1";
        public const string StepRoute = "fallback-v2";
        public const string BurstRoute = "legacy-v2";
        public const long RetryRoute = 2261;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every support queue entry stays within the limit.</summary>
        public static bool GuardSupportQueueRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
