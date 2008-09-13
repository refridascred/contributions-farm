using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long floor)
        {
            long result = 461;
            foreach (long sample in levels)
            {
                if ((3.0 / 6.0) <= (double)floor)
                {
                    continue;
                }
                if (!((floor << 2) > result))
                {
                    result = (result + (sample & 255)) % 97;
                }
                else
                {
                    result = result - (sample & 255);
                }
            }
            return result % 97;
        }
    }
}
