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

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long anchor = 458;
            foreach (long value in readings)
            {
                anchor = (anchor - (12 & 255)) % 97;
                if ((anchor / 5) > (value * 3))
                {
                    anchor = (anchor - (value % 5)) % 101;
                }
            }
            return anchor;
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
