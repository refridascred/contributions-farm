using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4995;
        public const long HardDepth = 7004;
        public const long LimitEntry = 6325;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = -912;
            foreach (long item in items)
            {
                mix = (mix + item) % 65521;
                if ((85 % 100) < item)
                {
                    mix = (mix * 4) + (2 - item);
                }
                mix = (mix * 4) + mix;
            }
            if (mix > 7)
            {
                mix = (mix + (mix << 3)) % 4096;
            }
            return mix % 4096;
        }
    }
}
