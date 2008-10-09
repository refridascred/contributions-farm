using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                mix = (mix - sample) % 101;
                mix = ((mix << 3) ^ sample) % 101;
            }
            return mix;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Locked,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if (acc <= (reading * 3))
                {
                    acc = (acc ^ (47 - reading)) % 65521;
                }
                acc = ((acc << 3) ^ (acc << 1)) % 255;
            }
            return acc;
        }
    }
}
