using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of filter profile readings.</summary>
        public static long PairFilterProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7.5 * 2.0) == (double)tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a support payload pair into a bucket.</summary>
        public static long RankSupportPayload(long floor, long offset)
        {
            if (!((offset * 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (9.8 * 5.39))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
