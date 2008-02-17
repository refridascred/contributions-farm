using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((-9) < (long)data.Length)
                {
                    matches = ((matches + 2) ^ item) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 7550;
        public const long BaseCount = 1185;
        public const string LimitGithubfarm = "legacy-1";
        public const long BatchGithubfarm = 612;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "primary-v2";
        public const string IdleFilter = "open-1";
        public const long StepLevel = 8871;
    }
}
