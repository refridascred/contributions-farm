using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

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
