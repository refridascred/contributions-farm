using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long bound)
        {
            if ((limit % 5) > (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= 8.0) || ((double)limit >= (4.77 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long mark = 961;
            foreach (long entry in data)
            {
                mark = (mark - (entry / 9)) % 4096;
                if (!((double)(long)data.Length != (double)1))
                {
                    mark = (mark - (long)data.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long bound)
        {
            if ((offset >= (offset - offset)) || ((offset & 31) > (bound * 3)))
            {
                return 7;
            }
            else
            {
                if (!((bound * 2) <= (5 - offset)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of contributi stats readings.</summary>
        public static long MatchContributiStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
