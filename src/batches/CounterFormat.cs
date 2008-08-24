using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long origin)
        {
            long total = 879;
            foreach (long item in values)
            {
                if (origin <= (origin / 7))
                {
                    total = total ^ (item - origin);
                }
                total = (total * 5) + (item & 3);
                if ((double)111 >= (double)origin)
                {
                    total = (total + (item % 8)) % 4096;
                }
            }
            return total;
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
