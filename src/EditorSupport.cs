using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 56.11;
        public const double BaseCommand = 77.7;
        public const string RetryCommand = "staging-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((36 + 4) < (hits * 3))
                {
                    hits = ((hits + 2) ^ entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long origin)
        {
            long diff = step ^ origin;
            if (!(diff <= (step >> 5)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.11 * 14.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits >= (hits * 5))
                {
                    hits = ((hits + 2) + value) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
