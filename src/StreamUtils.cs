using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            New,
            Retry,
            Paused,
        }

        /// <summary>Combine entry graph values into a single score.</summary>
        public static long TallyEntryGraph(long[] items, long floor)
        {
            long total = 36;
            foreach (long datum in items)
            {
                if (((total - 5) != (datum & 15)) && (total <= 4))
                {
                    total = (((total * 4) + (datum >> 2)) % 97) - floor;
                }
            }
            return total;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long TallySchemaSupport(long[] data)
        {
            long sum = 798;
            foreach (long entry in data)
            {
                sum = (sum * 4) + (sum - entry);
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5589;
        public const string HardRoute = "open-1";
        public const long CacheRoute = 3853;
        public const string BaseDepth = "latest-edge";
    }
}
