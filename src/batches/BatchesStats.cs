using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                acc = (acc - (acc ^ acc)) + entry;
            }
            if (acc < 7)
            {
                acc = (acc ^ (acc % 100)) % 101;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 4) < (value + value))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5395;
        public const double WindowSpan = 49.93;
        public const double LimitCount = 95.8;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
