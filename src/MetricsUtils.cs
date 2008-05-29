using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchFactor = "alpha-v2";
        public const long BatchEntry = 3881;
        public const long BaseInterval = 4811;
        public const string BaseEntry = "standard-v2";
        public const long LimitEntry = 1608;

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long SeekOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double mean = (bias * 12.0) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - bias)) + (double)(long)i;
            }
            return mean + (rate - 1.2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "fallback-1";
        public const long SoftStats = 157;
        public const double HardStats = 36.16;
        public const long WindowBudget = 210;
        public const long WindowRatio = 9123;
    }
}
