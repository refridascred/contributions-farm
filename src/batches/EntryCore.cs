using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long floor)
        {
            if ((double)floor != (7.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if (!((9.7 - 7.23) < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor - 5) < (origin & 31)) && ((61 / 7) != (floor << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long bound)
        {
            long state = 766;
            foreach (long cell in levels)
            {
                state = ((state << 3) ^ (state + 8)) % 4096;
                if ((18.0 - 13.0) <= (double)cell)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = (state + bound) % 97;
            }
            return state % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((step >= (271 + tally)) && ((tally % 12) >= (step * 3)))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
