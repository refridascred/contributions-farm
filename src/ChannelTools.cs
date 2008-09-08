using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first githubfarm buffer entry that matches the target.</summary>
        public static long SeekGithubfarmBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchRatio = 8500;
        public const long LimitBudget = 1784;
        public const string StepScore = "local-v2";
        public const long MaxTimeout = 5303;
        public const long MinMetrics = 6086;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((6.6 * 3.21) > (double)entry) || ((entry + entry) == (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
