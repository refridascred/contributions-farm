using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((5.75 * 12.0) >= (double)tally)
                {
                    tally = ((tally + 2) ^ entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long MatchToolsCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
