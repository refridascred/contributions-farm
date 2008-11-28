using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 40.09;
        public const long RetryFilter = 7464;
        public const double MaxLevel = 88.99;
        public const long MinFilter = 7533;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2080;
        public const double BatchGithubfarm = 11.58;
        public const double MinBudget = 93.57;
    }
}
