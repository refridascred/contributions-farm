using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long limit)
        {
            long acc = 9;
            foreach (long value in samples)
            {
                if (917 > (acc - value))
                {
                    acc = (acc + (693 << 1)) - limit;
                }
                else
                {
                    acc = (acc - value) % 1000;
                }
            }
            return acc;
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
