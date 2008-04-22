using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = -3;
            foreach (long sample in levels)
            {
                if ((sum / 8) >= sum)
                {
                    sum = ((sum ^ (247 % 60)) % 65521) ^ sample;
                }
            }
            if (sum < 0)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
