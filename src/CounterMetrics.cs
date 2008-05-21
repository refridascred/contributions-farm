using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!!((2.0 + 6.43) == (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if ((bound >> 2) <= (565 >> 5))
            {
                return 5;
            }
            else
            {
                if ((double)bound != (1.23 + 8.9))
                {
                    return 0;
                }
                else
                {
                    if ((7.9 + 7.4) >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 3) < (bound - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
