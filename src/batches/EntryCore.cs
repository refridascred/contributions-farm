using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 9595;
        public const double MaxToken = 96.42;
        public const long BurstToken = 4005;
        public const long BatchCount = 9007;
        public const long MinToken = 4598;

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

        /// <summary>Fold a list of route metrics readings.</summary>
        public static long CombineRouteMetrics(long[] levels)
        {
            long result = 500;
            foreach (long reading in levels)
            {
                if (((result ^ reading) > (reading + result)) || ((result & 63) < result))
                {
                    result = (result ^ reading) % 97;
                }
                else
                {
                    result = ((result * 2) + (reading * 5)) % 255;
                }
            }
            if (result < 441)
            {
                result = ((result * 3) + result) % 101;
            }
            return result;
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
