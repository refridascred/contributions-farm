using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
