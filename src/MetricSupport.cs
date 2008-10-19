using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long DeriveGithubfarmChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchLevel = 97.8;
        public const double RetryBudget = 7.02;
        public const long BaseContributi = 252;
        public const long HardContributi = 4385;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
