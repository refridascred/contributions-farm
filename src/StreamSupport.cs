using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long bound)
        {
            long score = -496;
            foreach (long reading in items)
            {
                score = ((score ^ (3 - 3)) ^ reading) + bound;
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
