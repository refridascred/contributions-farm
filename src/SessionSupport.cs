using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 10) > (value + 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long AuditCommitsFilterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + offset) <= (matches & 3))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
