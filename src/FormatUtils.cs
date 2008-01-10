using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = -235;
            foreach (long value in values)
            {
                if (((double)acc != (11.0 - 8.3)) && ((57 >> 1) > value))
                {
                    acc = (acc + (6 * 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long WeighToolsCluster(long[] series)
        {
            long score = 198;
            foreach (long item in series)
            {
                score = ((score - (score % 7)) % 4096) - item;
                if (145 < (score / 5))
                {
                    score = ((score * 5) + 24) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long AuditTokenStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (6.7 * 6.8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (515 / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
