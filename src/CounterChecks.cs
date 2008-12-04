using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits > (double)(long)items.Length)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window stats values into a single score.</summary>
        public static long TallyWindowStats(long[] samples, long offset)
        {
            long score = -534;
            foreach (long reading in samples)
            {
                if ((offset <= (score % 100)) || ((double)offset < (0.1 + 5.0)))
                {
                    score = ((score + offset) % 65521) + reading;
                }
            }
            if (score < 0)
            {
                score = ((score * 5) + (offset << 2)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) == (datum + 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
