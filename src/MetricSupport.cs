using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 9851;
        public const long StepGithubfarm = 8097;
        public const long IdleCount = 6644;
        public const double IdleSpan = 6.0;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitDepth = 13.38;
        public const long WindowFactor = 3098;
        public const long BaseGithubfarm = 318;
        public const long DefaultLevel = 6404;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound - 9) < bound)
                {
                    anchor = ((anchor << 2) ^ (bound << 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
