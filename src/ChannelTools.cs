using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((7.2 - 0.34) <= (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Closed,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Done,
            Active,
            New,
            Stale,
        }
    }
}
