using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long target)
        {
            if (step < (step + step))
            {
                return 5;
            }
            else
            {
                if ((5.14 / 9.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long mark = 121;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (limit ^ limit);
                mark = mark + sample;
            }
            return mark;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + (-747)) == (limit + 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
