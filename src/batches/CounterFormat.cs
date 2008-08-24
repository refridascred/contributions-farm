using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count < 74)
                {
                    count = ((count + 2) + cell) + offset;
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
