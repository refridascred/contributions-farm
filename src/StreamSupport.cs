using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            Ready,
            Retry,
        }
    }
}
