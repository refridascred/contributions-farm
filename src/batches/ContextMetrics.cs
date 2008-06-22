using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleInterval = 93.28;
        public const long MaxFactor = 3978;
        public const long StepQueue = 6898;
        public const long DefaultWidth = 9023;

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool CheckToolsStatsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long step2)
        {
            if ((10.0 * 9.5) >= (double)step2)
            {
                return 2;
            }
            else
            {
                if (step < (step & 1))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
