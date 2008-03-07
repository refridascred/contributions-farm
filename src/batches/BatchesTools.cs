using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 350;
            foreach (long sample in series)
            {
                mix = (mix + (sample - sample)) % 4096;
                mix = ((mix << 2) ^ (444 + mix)) % 1000;
                mix = mix ^ 3;
            }
            if (mix > 0)
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
