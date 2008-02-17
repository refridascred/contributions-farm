using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 7.13;
        public const long BurstSpan = 1815;
        public const double StepCount = 32.26;
        public const string IdleGithubfarm = "standard-v2";
        public const string DefaultBudget = "strict-v2";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics tools entries that pass the check.</summary>
        public static long TallyMetricsToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry + matches) > entry) && (matches > (5 >> 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
