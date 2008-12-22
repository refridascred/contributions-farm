using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats batch counter forward.</summary>
        public static long DeriveStatsBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (seed ^ seed)) % 97;
                long step = (long)i + (seed - (long)i);
                if (total < (total >> 1))
                {
                    total = (total << 3) ^ step;
                    total = total + (step - seed);
                    break;
                }
                else
                {
                    total = total + ((long)i >> 5);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the buffer session entries that pass the check.</summary>
        public static long AuditBufferSessionMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((3 * 5) <= (5 + target))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
