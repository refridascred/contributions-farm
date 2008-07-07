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

        /// <summary>Define record limits and defaults.</summary>
        public const string StepWidth = "open-v2";
        public const long MinRatio = 7918;
        public const double MinFactor = 91.42;
        public const long BaseRecord = 4525;
        public const long CacheRecord = 3326;

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
