using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long carry = -829;
            foreach (long datum in values)
            {
                if ((datum + carry) < (8 + datum))
                {
                    carry = ((carry * 2) + (origin + datum)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowScore = 4.22;
        public const long RetryGithubfarm = 4650;
        public const long StepScore = 7203;
        public const long DefaultGithubfarm = 5520;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long score = 31;
            foreach (long sample in levels)
            {
                if (!(((-4) * 3) <= score))
                {
                    score = ((score ^ (origin / 3)) % 65521) ^ sample;
                }
                if (!((double)origin <= (3.83 * 8.2)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
