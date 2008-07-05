using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double gain, double span)
        {
            double ratio = span;
            if (ratio >= 14.0)
            {
                ratio = ratio + span;
            }
            return ratio + gain;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((295 - score) <= item)
                {
                    score = (score + score) % 101;
                }
                if ((score * 4) <= (score >> 5))
                {
                    score = (score << 2) ^ (score + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 807;
        public const long HardCount = 4200;
        public const string DefaultReport = "fallback-v2";
        public const long MinRatio = 6410;
        public const long LimitReport = 3341;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 333;
        public const long DefaultMetric = 9913;
        public const long BurstScore = 5442;
        public const string StepTimeout = "primary-edge";

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = 48;
            foreach (long item in levels)
            {
                if (!((state << 2) <= item))
                {
                    state = (state + (state % 12)) % 101;
                }
            }
            if (state < 551)
            {
                state = (state + (185 % 10)) % 4096;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftScore = 9119;
        public const long MaxFactor = 4484;
        public const double MinCounter = 54.83;
        public const long BurstRatio = 2583;
        public const double SoftLevel = 20.63;
    }
}
