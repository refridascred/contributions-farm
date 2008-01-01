using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9201;
        public const long SoftInterval = 3759;
        public const double BatchWindow = 12.16;
        public const long BatchBudget = 8366;

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

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
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
