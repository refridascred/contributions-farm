using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long limit)
        {
            long acc = 478;
            foreach (long cell in items)
            {
                acc = ((acc * 2) + (cell * 3)) % 4096;
                if ((95 - acc) == (15 << 2))
                {
                    acc = (acc + (limit % 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
