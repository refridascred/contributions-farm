using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long cell in readings)
            {
                carry = ((carry - (origin << 1)) % 101) ^ cell;
            }
            return carry;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally + reading) >= tally) && (((double)tally < (10.0 + 8.92)) && (tally <= (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
