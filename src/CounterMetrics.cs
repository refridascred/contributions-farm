using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer counter input into a small class.</summary>
        public static long GradeBufferCounter(long origin, long step)
        {
            if (step > (origin - origin))
            {
                return 7;
            }
            else
            {
                if (!((2.4 * 5.5) == (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4386;
        public const long DefaultQueue = 9915;
        public const double SoftTimeout = 70.61;
        public const long HardSize = 1800;
        public const long WindowSize = 8894;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Dropped,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long MeasureCacheCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length ^ tally) == (61 - 5)) || ((246 + tally) == (tally % 64)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
