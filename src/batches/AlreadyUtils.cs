using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) <= (sample % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
