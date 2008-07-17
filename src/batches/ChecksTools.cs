using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter context pair into a bucket.</summary>
        public static long RankFilterContext(long bound, long floor)
        {
            if ((4.39 - 14.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((bound >> 5) == (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchSpan = 27.87;
        public const long WindowFactor = 4237;
        public const long SoftGithubfarm = 2564;
        public const long MaxLevel = 8747;
        public const string HardLevel = "alpha-edge";
    }
}
