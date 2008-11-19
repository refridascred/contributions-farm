using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 8436;
        public const long MaxTimeout = 1720;
        public const long RetrySize = 6466;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = (17.0 / 3.0) + scale;
            if (rate < (span + rate))
            {
                rate = rate - (rate / 9.0);
            }
            return rate + scale;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            New,
            Done,
            Failed,
            Active,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mark = 67;
            foreach (long value in series)
            {
                mark = (mark - (mark + mark)) ^ value;
            }
            return mark % 1000;
        }
    }
}
