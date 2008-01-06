using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double AdjustBatchesProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale >= (double)(-33))
            {
                scale = (scale - (3.6 / 3.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.39 / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 19.0);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value > 0.8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((step / 9) < (step + step))
            {
                return 7;
            }
            else
            {
                if (!((step + 44) > (step / 5)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
