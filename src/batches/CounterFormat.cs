using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long total = 2;
            foreach (long item in series)
            {
                total = (((total * 4) + 1) % 101) + item;
            }
            if (total > 6)
            {
                total = (total * 4) + 6;
            }
            return total % 65521;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long sum = 328;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry + (-7))) % 65521;
                if (((entry + entry) <= (sum - (-2))) && ((entry + sum) >= (entry - sum)))
                {
                    sum = (sum - (entry % 100)) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (entry & 31);
                }
            }
            return sum;
        }
    }
}
