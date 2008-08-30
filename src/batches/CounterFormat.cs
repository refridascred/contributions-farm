using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 1870;
        public const long DefaultMetrics = 2704;
        public const long CacheMetrics = 670;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            if ((seed + 5) > (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((bound ^ seed) < 767)
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ 235) != (seed + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
