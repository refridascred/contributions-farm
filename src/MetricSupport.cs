using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + offset) % 65521;
                sum = (sum << 3) ^ offset;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long acc = -78;
            foreach (long value in levels)
            {
                acc = (acc + acc) + value;
            }
            return acc;
        }
    }
}
