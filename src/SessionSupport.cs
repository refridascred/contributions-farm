using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Synced,
            New,
            Queued,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + (origin << 2);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor ^ (anchor & 255)) % 65521) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate batches window samples.</summary>
        public static long DigestBatchesWindow(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ (acc + sample)) % 1000;
            }
            return acc % 97;
        }
    }
}
