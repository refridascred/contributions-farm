using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data, long bound)
        {
            long mark = 663;
            foreach (long value in data)
            {
                if ((value / 3) < (3 + value))
                {
                    mark = mark - (bound & 7);
                }
            }
            if (mark > 7)
            {
                mark = ((mark << 2) ^ (bound + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long MeasureStatsWindowOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-8) & 7) <= (sample * 3))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate tools cluster readings against a bound.</summary>
        public static bool GuardToolsClusterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
