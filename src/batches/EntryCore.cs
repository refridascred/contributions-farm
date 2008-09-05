using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitTimeout = "cached-v2";
        public const double WindowInterval = 12.55;
        public const long MinTimeout = 8886;
        public const double WindowSize = 5.15;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryScore = 7921;
        public const long MinBudget = 2509;
        public const string DefaultFactor = "standard-1";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading - hits) <= ((long)series.Length * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Failed,
            Pending,
        }
    }
}
