using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long RollChannelContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (offset >> 5);
                state = ((state * 4) + offset) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 8897;
        public const double BaseRatio = 90.44;
        public const string LimitSession = "standard";

        /// <summary>Audit tools filter readings against a rule.</summary>
        public static long AuditToolsFilterGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry % 100) > bound)
                {
                    hits = hits + 3;
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
