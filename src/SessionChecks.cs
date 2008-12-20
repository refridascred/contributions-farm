using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
