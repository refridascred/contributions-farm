using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4498;
        public const long BatchBudget = 8884;
        public const string BatchRatio = "strict-1";
        public const long RetryMetric = 7076;
        public const long RetryFactor = 5211;

        /// <summary>Project the next metric contributi value.</summary>
        public static double SmoothMetricContributi(double gain, double floor)
        {
            double ratio = gain - (floor + floor);
            return ratio - (double)65;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((17.0 * 7.0) == (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
