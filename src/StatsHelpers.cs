using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstTimeout = 78.08;
        public const long MinCount = 3512;
        public const long RetryStream = 4629;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((1.09 * 8.57) == (double)count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double mean = offset * 4.01;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Closed,
            Dropped,
            Stale,
        }
    }
}
