using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count tools graph pairs that satisfy a relation.</summary>
        public static long CompareToolsGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + sample) > (tally - tally)) || ((origin / 6) > (sample + 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long FoldChecksBuffer(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((result + result) <= cell)
                {
                    result = (result - cell) % 101;
                }
            }
            if (result < 630)
            {
                result = (result * 5) + (result & 1);
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
