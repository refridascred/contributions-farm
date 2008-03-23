using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long score = 439;
            foreach (long sample in series)
            {
                score = score ^ seed;
                if (!((seed % 24) == ((long)series.Length / 3)))
                {
                    score = (score + (48 ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ ((long)i & 127)) % 4096;
                if (!(offset > ((long)i + (long)i)))
                {
                    state = (state + (offset % 8)) % 101;
                }
                state = (state + (954 + offset)) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Draft,
            New,
            Retry,
            Stale,
        }
    }
}
