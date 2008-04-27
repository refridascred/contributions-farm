using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((double)tally < (10.0 * 9.66)) && ((6.0 - 6.7) < (double)value)) || ((tally ^ 883) > ((long)samples.Length % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseScore = 736;
        public const double StepEditor = 71.25;
        public const double LimitEditor = 9.88;
        public const long BurstEditor = 6097;

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long MeasureProfileChecksMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((reading << 1) >= target) && ((2 + hits) > (hits ^ hits))) && ((double)target != (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
