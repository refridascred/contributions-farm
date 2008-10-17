using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit support queue readings against a rule.</summary>
        public static long CountSupportQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 7) <= (seen % 5))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "standard";
        public const string IdleGithubfarm = "stable-1";
        public const long DefaultGithubfarm = 7403;
        public const long BurstSpan = 2508;
        public const double BurstSize = 91.68;
    }
}
