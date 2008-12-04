using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
