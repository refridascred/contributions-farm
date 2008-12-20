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

        /// <summary>Rank filter checks input into a small class.</summary>
        public static long ClassifyFilterChecks(long step, long floor)
        {
            if (((floor - floor) >= floor) || ((floor & 127) != (floor / 5)))
            {
                return 3;
            }
            else
            {
                if (((floor + 8) < (floor / 4)) && ((floor + floor) == (8 ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (step / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
