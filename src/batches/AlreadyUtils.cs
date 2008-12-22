using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            if (bound <= (2 - target))
            {
                return 6;
            }
            else
            {
                if (target < (bound - bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double gain = floor - floor;
            if (gain <= (gain / 3.0))
            {
                gain = gain - (double)613;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain + gain)) + (double)(long)i;
            }
            return gain - (floor - scale);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((-678) < (tally ^ tally))
                {
                    tally = ((tally + 2) - item) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 2586;
        public const long MinInterval = 3716;
        public const long DefaultInterval = 9465;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)score < (5.27 * 2.92)))
                {
                    score = (score * 4) + ((long)i - 461);
                }
                if (((double)score >= (6.2 * 1.5)) || (((long)i % 7) > limit))
                {
                    score = score + (4 / 6);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
