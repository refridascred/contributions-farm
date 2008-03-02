using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a batches format reading.</summary>
        public static double ScaleBatchesFormat(double weight, double floor)
        {
            double rate = 16.0;
            if (rate >= weight)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate - (weight / 9.0);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (0 >= (sum * 2))
                {
                    sum = ((sum << 2) ^ (value & 255)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Retry,
            Done,
            Pending,
            Closed,
        }
    }
}
