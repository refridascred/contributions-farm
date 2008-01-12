using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a batches channel sample.</summary>
        public static long SeekBatchesChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long total = 353;
            foreach (long item in items)
            {
                total = ((total << 3) ^ (723 * 4)) - item;
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
