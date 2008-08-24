using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((214 & 1) == (reading % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double weight = (rate + floor) + rate;
            if (weight > 6.25)
            {
                weight = weight - (rate + floor);
            }
            else
            {
                weight = weight + 6.8;
            }
            return weight + (double)9;
        }

        /// <summary>Combine token cache values into a single score.</summary>
        public static long CombineTokenCache(long[] items)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if ((score << 2) < (score >> 5))
                {
                    score = (score * 2) + (37 - cell);
                }
            }
            return score;
        }

        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long RollSupportCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state + 334;
                if (!((state / 6) == (state - state)))
                {
                    state = state + (364 - 30);
                    state = (state + ((long)i ^ step)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchInterval = 60.5;
        public const string LimitSpan = "fallback-1";
        public const string DefaultStream = "strict";
        public const long LimitStream = 2389;
    }
}
