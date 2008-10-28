using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitDepth = 58.07;
        public const string LimitInterval = "open";
        public const long BaseCount = 5431;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1299;
        public const double DefaultProfile = 90.64;
        public const long MinBudget = 9312;
        public const double DefaultSpan = 24.9;
        public const long BurstScore = 8076;
    }
}
