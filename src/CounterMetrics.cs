using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long ScoreOrderGithubfarm(long[] items)
        {
            long result = 433;
            foreach (long value in items)
            {
                if (!((value + result) == (85 * 2)))
                {
                    result = ((result * 5) + (-55)) % 101;
                }
                result = result ^ (value + value);
            }
            if (result > 98)
            {
                result = result - 506;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultTimeout = 53.08;
        public const string IdleProfile = "stable-1";
        public const string LimitProfile = "staging-v2";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value & 15) >= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
