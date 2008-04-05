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

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long ScoreOrderGithubfarm(long[] items)
        {
            long result = 433;
            foreach (long value in items)
            {
                if (!((value + result) == (85 * 2)))
                {
                    result = ((result * 5) + (-55)) % 101;
                }
                result = result ^ (value + value);
            }
            if (result > 98)
            {
                result = result - 506;
            }
            return result;
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
