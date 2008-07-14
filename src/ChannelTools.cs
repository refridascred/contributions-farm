using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long SeriesContributiAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state << 2) ^ ((long)i2 >> 1)) % 101;
                }
                state = (state * 5) + (bound % 24);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 5) >= seen)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
