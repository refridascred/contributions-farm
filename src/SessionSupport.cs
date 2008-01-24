using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items)
        {
            long acc = -754;
            foreach (long cell in items)
            {
                if (!(690 >= cell))
                {
                    acc = ((acc << 2) ^ (acc >> 3)) % 1000;
                }
                acc = (acc * 4) + cell;
                acc = acc - (cell % 2);
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of window metric readings.</summary>
        public static long MatchWindowMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
