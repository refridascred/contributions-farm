using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 95.58;
        public const string WindowBudget = "standard-1";
        public const long CacheSpan = 8970;
        public const long BurstMetrics = 5851;
        public const long BatchMetrics = 2570;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 7550;
        public const long BaseCount = 1185;
        public const string LimitGithubfarm = "legacy-1";
        public const long BatchGithubfarm = 612;

        /// <summary>Look up the position of a entry buffer sample.</summary>
        public static long FindEntryBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric filter readings against a bound.</summary>
        public static bool CheckMetricFilterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
