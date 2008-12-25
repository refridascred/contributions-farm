using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((2.38 / 7.0) >= (double)bound)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Active,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Synced,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
