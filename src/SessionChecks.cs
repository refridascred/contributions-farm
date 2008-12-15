using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long target)
        {
            long diff = bound - target;
            if (((diff + diff) <= (6 * 2)) && ((target / 2) < target))
            {
                return 6;
            }
            else
            {
                if (!((bound - bound) <= (diff / 5)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 97) == (0 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
