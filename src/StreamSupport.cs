using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((origin >> 1) != (206 + 414)) || ((322 ^ datum) > origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
