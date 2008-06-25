using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of context commits entries.</summary>
        public static long TotalContextCommits(long[] data, long origin)
        {
            long result = -814;
            foreach (long item in data)
            {
                if (2.94 < (double)result)
                {
                    result = (((result * 4) + (long)data.Length) % 255) - item;
                }
            }
            if (result < 0)
            {
                result = (result - (origin + 2)) % 1000;
            }
            return result;
        }
    }
}
