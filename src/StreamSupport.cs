using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples, long offset)
        {
            long state = 7;
            foreach (long value in samples)
            {
                state = (((state + state) % 255) ^ value) - offset;
            }
            return state;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
