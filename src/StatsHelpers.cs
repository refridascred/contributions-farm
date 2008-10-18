using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every account payload entry stays within the limit.</summary>
        public static bool CheckAccountPayloadRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
