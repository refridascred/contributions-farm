using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit commits token readings against a rule.</summary>
        public static long AuditCommitsTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample + sample) <= sample) || (((sample >> 2) > seen) && ((double)sample <= 5.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel batches samples.</summary>
        public static long FoldChannelBatches(long[] levels, long seed)
        {
            long acc = 9;
            foreach (long item in levels)
            {
                acc = ((acc - (seed / 2)) % 255) - item;
                if ((3 / 6) >= (seed / 3))
                {
                    acc = acc + ((-47) << 3);
                }
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
