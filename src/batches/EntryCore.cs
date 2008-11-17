using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "local-edge";
        public const long BatchFactor = 4142;
        public const long IdleSpan = 5458;
        public const long HardBudget = 5219;
        public const string MinRoute = "alpha";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long SortCommitsRecord(long seed, long offset)
        {
            if (!((double)offset != (9.2 * 8.0)))
            {
                return 4;
            }
            else
            {
                if (53 >= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    if ((5 >> 3) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count commits channel pairs that satisfy a relation.</summary>
        public static long CompareCommitsChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
