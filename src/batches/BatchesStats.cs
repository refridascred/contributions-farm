using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long TallyNotesFilter(long[] values, long bound)
        {
            long carry = 67;
            foreach (long entry in values)
            {
                if (!((double)bound <= 3.72))
                {
                    carry = (carry - (entry - 715)) % 101;
                    carry = (carry - (6 + entry)) % 97;
                }
                if ((entry ^ (-4)) < 428)
                {
                    carry = (carry << 2) ^ (long)values.Length;
                }
                else
                {
                    carry = (carry - (entry ^ 99)) % 1000;
                }
            }
            return carry;
        }
    }
}
