using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long step)
        {
            long diff = seed + step;
            if (!((step + seed) >= (diff & 31)))
            {
                return 5;
            }
            else
            {
                if ((step % 100) < ((-1) % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Pending,
            Closed,
            Done,
            Synced,
        }
    }
}
