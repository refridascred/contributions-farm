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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
