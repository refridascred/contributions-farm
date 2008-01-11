using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Draft,
            New,
            Pending,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account order counter forward.</summary>
        public static long RollAccountOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (mix >> 1)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
