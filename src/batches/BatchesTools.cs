using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile record entries.</summary>
        public static long TallyProfileRecord(long[] values)
        {
            long result = 11;
            foreach (long sample in values)
            {
                result = ((result << 3) ^ (result >> 5)) + sample;
            }
            return result;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.0 + 20.0) != (double)floor)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
