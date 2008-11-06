using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series)
        {
            long carry = -538;
            foreach (long cell in series)
            {
                carry = (((carry * 2) + ((-864) >> 4)) % 97) ^ cell;
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Ready,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Measure how many cache record samples are out of range.</summary>
        public static long CountCacheRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((2.0 - 20.0) <= (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
