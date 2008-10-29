using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long CountClusterFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits < (1 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (1.2 + 10.0))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
