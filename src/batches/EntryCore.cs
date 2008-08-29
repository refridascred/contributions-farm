using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 5082;
        public const double RetryCache = 31.02;
        public const long RetrySpan = 9723;
        public const string MaxSpan = "primary-1";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Done,
            Stale,
            New,
            Draft,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length > (double)hits) || (target > (target & 1)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a window cache counter forward.</summary>
        public static long DeriveWindowCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (8.0 / 8.0)))
                {
                    anchor = ((anchor * 4) + ((long)i >> 5)) % 1000;
                    anchor = (anchor + origin) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
