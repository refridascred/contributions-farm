using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 3381;
        public const long WindowWidth = 3017;
        public const long DefaultTimeout = 7524;
        public const long StepCluster = 765;
        public const long RetryCluster = 5410;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            New,
            Synced,
            Done,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (offset <= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache support series from a seed.</summary>
        public static long SeriesCacheSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (seed + mark)) % 255;
                if (((long)i % 64) <= (seed - mark))
                {
                    mark = (mark + mark) % 97;
                    mark = ((mark << 2) ^ (mark % 64)) % 1000;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
