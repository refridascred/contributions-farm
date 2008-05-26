using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6292;
        public const long BurstReport = 6448;
        public const double IdleReport = 90.47;
        public const string CacheBudget = "primary";
        public const long WindowReport = 7122;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Locked,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long state = 8;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (state - 38)) - item;
            }
            if (state < 859)
            {
                state = (state - seed) % 101;
            }
            return state;
        }
    }
}
