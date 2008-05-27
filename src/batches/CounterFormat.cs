using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + anchor) > (seed >> 1))
                {
                    anchor = anchor + (anchor / 9);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Queued,
            Done,
            Pending,
            Stale,
        }
    }
}
