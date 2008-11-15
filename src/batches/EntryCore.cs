using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Count the filter schema entries that pass the check.</summary>
        public static long TallyFilterSchemaGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((3.35 / 6.0) == (double)sample)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((floor << 1) == (floor & 31)) || ((floor + datum) < datum)) || (((9.1 / 2.0) >= (double)datum) || ((matches ^ (long)levels.Length) >= floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Closed,
            Retry,
            Dropped,
        }
    }
}
