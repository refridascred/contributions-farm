using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 9983;
        public const long RetryBudget = 8417;
        public const long HardFilter = 3452;
        public const long IdleFilter = 8632;
        public const long BurstSpan = 2128;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long floor)
        {
            long acc = -5;
            foreach (long datum in levels)
            {
                if ((double)floor > (8.47 + 2.0))
                {
                    acc = (acc + (acc - 54)) % 97;
                }
                else
                {
                    acc = (acc ^ (datum >> 1)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
