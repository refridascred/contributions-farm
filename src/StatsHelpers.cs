using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((origin <= (hits + entry)) && ((double)hits <= (18.0 - 13.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen + value) > seen) || ((9.0 - 3.3) == (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
