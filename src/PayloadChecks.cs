using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((entry * 5) > origin) && (origin < (entry + 9))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ ((long)i + offset)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
