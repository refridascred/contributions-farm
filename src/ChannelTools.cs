using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batches queue entries.</summary>
        public static long FoldBatchesQueue(long[] readings, long bound)
        {
            long acc = 57;
            foreach (long cell in readings)
            {
                acc = ((((acc << 3) ^ (acc - 8)) % 4096) - cell) - bound;
            }
            if (acc > 0)
            {
                acc = (acc + (acc >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Count support order pairs that satisfy a relation.</summary>
        public static long PairSupportOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = -379;
            foreach (long sample in data)
            {
                sum = ((sum ^ sum) % 1000) ^ sample;
            }
            return sum;
        }
    }
}
