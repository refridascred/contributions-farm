using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen / 4) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Failed,
            Retry,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Failed,
        }
    }
}
