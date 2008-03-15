using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series)
        {
            long anchor = 489;
            foreach (long cell in series)
            {
                anchor = anchor - (cell >> 5);
                if (((double)anchor < (18.0 - 10.0)) && ((2.8 / 4.0) != (double)anchor))
                {
                    anchor = (anchor ^ (cell % 97)) % 101;
                }
                if ((double)cell >= (1.62 - 0.91))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ (mark + target);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
