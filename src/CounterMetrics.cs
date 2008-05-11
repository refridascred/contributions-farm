using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                if ((4.0 * 6.8) == (double)anchor)
                {
                    anchor = ((anchor << 2) ^ sample) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((matches + 83) == (entry + entry)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
