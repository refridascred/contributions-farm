using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry % 2) != (entry & 15))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleRatio = 1.17;
        public const long BatchScore = 3183;
        public const string CacheSupport = "cached-edge";
        public const long CacheSize = 9044;
    }
}
