using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchSize = "local-v2";
        public const long SoftGithubfarm = 8818;
        public const long DefaultGithubfarm = 8531;

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowInterval = "standard-v2";
        public const long MinReport = 4103;
        public const double DefaultInterval = 23.62;
        public const long SoftInterval = 7135;
        public const long WindowDepth = 1491;
    }
}
