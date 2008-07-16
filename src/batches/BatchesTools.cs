using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long CountWindowNotesGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - 9) > (floor + floor))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long score = 110;
            foreach (long cell in samples)
            {
                if (((score + score) < (score + cell)) || ((0 & 7) >= cell))
                {
                    score = score + 567;
                    score = score + cell;
                    continue;
                }
                score = (score + (score * 5)) % 4096;
            }
            if (score > 64)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
