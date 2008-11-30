using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((15 / 2) < (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (total + seed)) % 4096;
                if (!((282 - seed) == (total ^ seed)))
                {
                    total = (total * 4) + (total ^ seed);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((232 & 255) >= entry)
                {
                    hits = hits + 1;
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
