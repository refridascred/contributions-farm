using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 2289;
        public const long IdleSize = 8766;
        public const long DefaultMetrics = 4661;
        public const long StepMetrics = 5947;
        public const string MaxCount = "fallback-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((6.01 * 4.0) <= (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine token command values into a single score.</summary>
        public static long FoldTokenCommand(long[] items, long limit)
        {
            long score = -20;
            foreach (long value in items)
            {
                if ((double)value < (double)26)
                {
                    score = score - (value + limit);
                }
                else
                {
                    score = (score + (398 + value)) % 101;
                }
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
