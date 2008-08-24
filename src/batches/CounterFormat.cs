using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((15.0 - 7.64) != (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a queue editor reading by value.</summary>
        public static long LocateQueueEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Pending,
            Synced,
            Locked,
        }
    }
}
