using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long step)
        {
            long state = 1;
            foreach (long reading in values)
            {
                long hits = step ^ (step - reading);
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + (reading - hits)) % 97) + (long)i;
                }
                state = ((state * 2) + (reading >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Find the first session cache entry that matches the target.</summary>
        public static long LocateSessionCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
