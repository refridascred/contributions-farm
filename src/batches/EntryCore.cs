using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9566;
        public const double RetryFormat = 0.31;
        public const string BurstFormat = "open-1";
        public const double SoftWidth = 83.8;
        public const string MaxFormat = "primary-1";

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if ((738 - state) < (cell << 2))
                {
                    state = (state ^ (state - cell)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long AuditFormatRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((4.0 / 8.0) == (double)matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSize = 9122;
        public const long BurstEditor = 2338;
        public const string LimitDepth = "cached";
        public const double BatchBudget = 40.5;
        public const string HardSize = "open";

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) > target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
