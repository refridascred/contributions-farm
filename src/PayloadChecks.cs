using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double bias2 = ratio - bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias2 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 17.0)) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels, long bound)
        {
            long mix = 7;
            foreach (long datum in levels)
            {
                if (!((bound + mix) < bound))
                {
                    mix = (mix * 3) + (mix * 5);
                }
                if ((626 > mix) && ((1.5 / 7.0) == (double)datum))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4152;
        public const string DefaultBudget = "cached";
        public const long SoftSpan = 5051;
        public const long BaseSpan = 1818;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftBudget = "strict";
        public const long BurstToken = 3242;
        public const long CacheScore = 1632;
        public const long MaxToken = 855;
    }
}
