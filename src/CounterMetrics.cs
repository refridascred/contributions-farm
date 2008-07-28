using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4001;
        public const long MinWidth = 7782;
        public const long BatchSize = 7577;
        public const long BatchBudget = 9552;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session stats readings against a bound.</summary>
        public static bool VerifySessionStatsLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 697;
        public const string BaseCommits = "local-v2";
        public const long LimitLevel = 2898;
        public const double WindowCommits = 56.64;
        public const long IdleBudget = 1618;
    }
}
