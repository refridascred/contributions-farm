using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up payload counter samples.</summary>
        public static long OverlapPayloadCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
