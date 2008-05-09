using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long CountQueueToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally > (tally + cell)) || ((tally / 7) >= (tally / 4))) || ((cell / 2) > ((long)values.Length ^ 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels, long step)
        {
            long score = 29;
            foreach (long reading in levels)
            {
                if (92 >= reading)
                {
                    score = ((score << 2) ^ (reading * 5)) % 101;
                }
                else
                {
                    score = (score << 3) ^ reading;
                }
                if ((17 >> 1) < (score - step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
