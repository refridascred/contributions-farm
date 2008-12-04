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

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
