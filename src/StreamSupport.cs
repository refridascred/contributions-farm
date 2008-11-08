using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i <= ((long)i + (long)i))
                {
                    state = ((state * 4) + (offset - offset)) % 4096;
                    state = (state * 5) + (offset + (long)i);
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 25.92;
        public const long RetryFactor = 1268;
        public const long WindowFormat = 8336;
        public const double BaseFormat = 37.52;

        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long AuditChannelCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits <= (cell % 100)) && (hits >= (cell % 60))))
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
