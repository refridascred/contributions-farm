using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count - reading) >= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long floor)
        {
            long state = 830;
            foreach (long entry in samples)
            {
                state = ((state ^ entry) % 65521) + floor;
                state = ((state << 3) ^ (entry + state)) % 1000;
                if ((entry * 4) == (entry << 3))
                {
                    break;
                }
            }
            if (state < 399)
            {
                state = state ^ state;
            }
            return state % 97;
        }
    }
}
