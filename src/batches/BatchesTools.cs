using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout farm samples are out of range.</summary>
        public static long MeasureLayoutFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading <= (5 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter already readings against a rule.</summary>
        public static long TallyCounterAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((34 ^ matches) < (877 % 7))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
