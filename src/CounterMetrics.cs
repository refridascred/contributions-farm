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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((slot - floor) <= bound)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (double)slot)
                {
                    return 4;
                }
                else
                {
                    if (((bound / 4) < (8 + floor)) || ((15.0 * 8.81) >= (double)slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already buffer samples are out of range.</summary>
        public static long CountAlreadyBufferGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((limit & 7) > limit)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
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
