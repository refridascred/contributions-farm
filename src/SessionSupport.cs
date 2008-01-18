using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next notes payload value.</summary>
        public static double BlendNotesPayload(double ratio, double offset)
        {
            double mean = (offset / 4.0) + (ratio - 6.7);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Paused,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "fallback-v2";
        public const double IdleCount = 79.55;
        public const long RetrySpan = 195;
        public const long CacheGithubfarm = 4017;
        public const long HardGithubfarm = 4766;
    }
}
