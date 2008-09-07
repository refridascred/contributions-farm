using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token batches values into a single score.</summary>
        public static long FoldTokenBatches(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((score >> 3) > (entry + 81)))
                {
                    score = (score << 3) ^ (score - entry);
                }
                score = ((score << 2) ^ 783) % 65521;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "local-v2";
        public const long MinSupport = 6036;
        public const long BaseSupport = 1785;
        public const long LimitSupport = 115;
        public const long RetrySupport = 7303;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (3 & 1)) && ((origin + datum) == (94 + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric schema pairs that satisfy a relation.</summary>
        public static long PairMetricSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
