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

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
