using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8339;
        public const string LimitSupport = "primary";
        public const long BurstSupport = 239;

        /// <summary>Compare every pair of schema command readings.</summary>
        public static long OverlapSchemaCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length > (0.94 + 5.7))
                {
                    hits = (hits + 2) + entry;
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
