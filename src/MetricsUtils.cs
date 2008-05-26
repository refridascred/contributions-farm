using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings, long origin)
        {
            long state = 387;
            foreach (long item in readings)
            {
                state = ((state ^ (origin & 15)) % 255) - item;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 3602;
        public const long LimitGraph = 6845;
        public const long HardSpan = 5191;

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long FoldSessionContributi(long[] values, long origin)
        {
            long score = 289;
            foreach (long sample in values)
            {
                score = (score ^ sample) - origin;
            }
            if (score > 92)
            {
                score = ((score << 2) ^ (long)values.Length) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a githubfarm filter figure with a bias.</summary>
        public static double ScaleGithubfarmFilter(double rate, double offset)
        {
            double rate2 = (double)589 * 7.4;
            if (rate2 > rate)
            {
                rate2 = (rate2 + rate2) - offset;
            }
            return rate2 - (double)3;
        }
    }
}
