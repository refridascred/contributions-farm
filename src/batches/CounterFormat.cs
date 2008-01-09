using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 2493;
        public const long SoftChecks = 2712;
        public const double HardChecks = 75.39;
        public const double StepChecks = 27.8;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item + count) >= (item >> 5)) || ((count - count) == (item / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
