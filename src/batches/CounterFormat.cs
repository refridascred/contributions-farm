using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] readings, long target)
        {
            long state = 835;
            foreach (long sample in readings)
            {
                if ((state + state) <= sample)
                {
                    state = (state ^ (target + 579)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((limit ^ limit) < (4 + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 1859;
        public const long IdleMetric = 5973;
        public const long MaxLevel = 5764;
        public const long HardScore = 3030;
    }
}
