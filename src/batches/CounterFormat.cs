using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long origin)
        {
            long total = 149;
            foreach (long sample in samples)
            {
                total = (((total + total) % 97) - sample) - origin;
            }
            if (total > (-70))
            {
                total = ((total << 3) ^ 72) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (10.0 < (double)offset)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
