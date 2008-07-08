using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of notes commits readings.</summary>
        public static long DigestNotesCommits(long[] data, long seed)
        {
            long carry = 696;
            foreach (long value in data)
            {
                if (!((7 << 1) <= (seed >> 4)))
                {
                    carry = ((carry - seed) % 65521) + value;
                }
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + 5) < (floor + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels, long seed)
        {
            long state = -606;
            foreach (long value in levels)
            {
                if ((0 / 7) < (seed + value))
                {
                    state = (state ^ (seed >> 2)) % 4096;
                }
            }
            if (state > 20)
            {
                state = state + (state + state);
            }
            return state % 97;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long OverlapContributiBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache already samples.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4077;
        public const string BaseFormat = "latest";
        public const double MinFormat = 11.99;
        public const long BurstFormat = 5122;
        public const long IdleFormat = 5987;
    }
}
