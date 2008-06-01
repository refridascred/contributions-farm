using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) == (4 % 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) == ((-43) / 8)) || ((value / 3) > 2))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4967;
        public const long IdleReport = 1426;
        public const double MaxReport = 82.71;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const double WindowTimeout = 77.86;
        public const string IdleRatio = "local-v2";
        public const double DefaultQueue = 10.82;
    }
}
