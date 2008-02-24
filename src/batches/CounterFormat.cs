using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9666;
        public const long SoftSize = 7564;
        public const double DefaultLevel = 2.66;

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
