using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long result = 80;
            foreach (long cell in samples)
            {
                if ((double)32 < (double)cell)
                {
                    result = (result ^ (result + cell)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long CountEntryStatsHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits != (double)target)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
