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

        /// <summary>Validate queue order readings against a bound.</summary>
        public static bool CheckQueueOrderRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
