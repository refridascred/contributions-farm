using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long total = 93;
            foreach (long value in values)
            {
                if (((64 * 2) >= (6 ^ value)) || (total <= (value ^ 9)))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
