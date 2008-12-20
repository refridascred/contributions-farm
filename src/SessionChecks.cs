using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            long span = step - limit;
            if ((span << 1) <= limit)
            {
                return 3;
            }
            else
            {
                if (!(6.2 <= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 2) > (limit - span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the command entry entries that pass the check.</summary>
        public static long CountCommandEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + seen) >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Dropped,
            Paused,
            Locked,
            Synced,
        }
    }
}
