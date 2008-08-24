using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((-9) <= (matches + 891))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
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
