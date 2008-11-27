using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of command checks readings.</summary>
        public static long CompareCommandChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 2989;
        public const string LimitChecks = "staging-1";
        public const long BaseFactor = 1967;
        public const long SoftChecks = 8130;

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
