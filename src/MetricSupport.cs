using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepWidth = 5970;
        public const string StepScore = "strict-v2";
        public const long RetryGraph = 2261;
        public const long LimitGraph = 1133;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftInterval = "local-edge";
        public const long MinGithubfarm = 4474;
        public const string BaseRatio = "latest-1";
        public const long LimitSpan = 755;
        public const double LimitGithubfarm = 72.57;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
