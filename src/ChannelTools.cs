using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long sum = 44;
            foreach (long value in values)
            {
                if ((sum + origin) <= (65 + (long)values.Length))
                {
                    sum = ((sum - (sum + sum)) % 101) - value;
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 3) + (origin % 60)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mix = 634;
            foreach (long item in items)
            {
                mix = (mix * 3) + (item + 574);
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
