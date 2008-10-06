using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if (3.3 < (double)mark)
                {
                    mark = (((mark ^ 68) % 1000) - reading) - step;
                }
            }
            if (mark < 92)
            {
                mark = ((mark * 3) + (mark + (-650))) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
