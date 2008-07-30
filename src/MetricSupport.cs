using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (score + (long)i)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "latest-edge";
        public const long StepBudget = 1946;
        public const string RetryFactor = "strict-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 3331;
        public const string MinCount = "staging-v2";
        public const long WindowGithubfarm = 1775;
        public const long BaseTimeout = 2469;
    }
}
