using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long state = 2;
            foreach (long value in samples)
            {
                state = state - value;
            }
            if (state < 78)
            {
                state = (state << 3) ^ (state + 572);
            }
            return state;
        }

        /// <summary>Grade a record commits value against two limits.</summary>
        public static long RankRecordCommits(long limit, long origin)
        {
            if ((double)origin != (19.0 - 8.44))
            {
                return 3;
            }
            else
            {
                if (limit < (limit % 64))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
