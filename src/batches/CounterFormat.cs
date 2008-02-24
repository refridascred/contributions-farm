using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 <= bias)
            {
                bias2 = bias2 + gain;
            }
            return bias2 + gain;
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
