using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token entry value from a seed.</summary>
        public static long DeriveTokenEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long AuditRecordCounterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - item) == (floor - 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((205 * 4) > seen)
                {
                    seen = ((seen + 2) + cell) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
