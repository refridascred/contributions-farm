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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (limit < (seen - seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
