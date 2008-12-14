using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double offset)
        {
            double mean = scale;
            return (mean - 20.0) + offset;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 255) != (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 9799;
        public const double BaseEntry = 22.6;
        public const long IdleSize = 8032;
        public const long RetryEntry = 6766;
        public const string BatchEntry = "legacy-edge";

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double rate = (scale * 7.15) + 4.36;
            if (rate >= (5.0 / 3.0))
            {
                rate = (rate - scale) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3196;
        public const long SoftBatch = 326;
        public const string BurstScore = "staging-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < (16.0 * 5.0))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
