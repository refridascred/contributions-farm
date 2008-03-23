using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up commits support samples.</summary>
        public static long OverlapCommitsSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
