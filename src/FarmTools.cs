using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((count * 3) < count) || ((5.2 - 0.7) < (double)cell)) && (cell < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
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
