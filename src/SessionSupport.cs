using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Done,
            Idle,
            New,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long floor)
        {
            if (floor > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (9.44 >= (double)item)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
