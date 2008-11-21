using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                mark = mark ^ (item % 7);
            }
            return mark;
        }

        /// <summary>Roll a token batches counter forward.</summary>
        public static long IterateTokenBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i & 1)) % 255;
                mark = (mark + (mark >> 3)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
