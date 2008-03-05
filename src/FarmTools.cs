using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings, long bound)
        {
            long result = 60;
            foreach (long cell in readings)
            {
                result = ((result << 3) ^ (cell + cell)) + bound;
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Done,
            Paused,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 7894;
        public const string BaseDepth = "standard-1";
        public const long SoftGithubfarm = 5606;
        public const string LimitBudget = "stable";
        public const double LimitGithubfarm = 63.34;
    }
}
