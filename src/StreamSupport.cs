using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                if ((sample >> 2) == (sum >> 3))
                {
                    sum = (sum * 5) + (sum - 11);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits <= (double)entry)
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 3136;
        public const long SoftLevel = 8776;
        public const long IdlePayload = 5122;
    }
}
