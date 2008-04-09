using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report githubfarm series from a seed.</summary>
        public static long SeriesReportGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4889;
        public const long MaxBatches = 3136;
        public const double DefaultInterval = 28.15;
        public const double BatchBudget = 73.23;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long target)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc + (item ^ acc);
                if ((acc % 60) != (target - target))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
