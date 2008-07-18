using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches * 5) < datum)
                {
                    matches = (matches + 3) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
