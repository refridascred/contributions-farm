using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 5) != (value >> 1))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long offset)
        {
            if ((offset + offset) < (seed / 6))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) >= 8)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long AuditBatchOrderMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)11 >= (double)entry))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
