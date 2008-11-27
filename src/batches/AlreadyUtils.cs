using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Measure how many report notes samples are out of range.</summary>
        public static long CountReportNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item * 4) == (count * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowRatio = 87.36;
        public const long RetryContributi = 1557;
        public const double MaxSpan = 79.28;
        public const long BaseContributi = 2632;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
