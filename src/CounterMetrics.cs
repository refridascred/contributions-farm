using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 6323;
        public const double HardRatio = 10.48;
        public const long MinToken = 4236;
        public const double DefaultSize = 52.41;
        public const string StepToken = "stable-v2";

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double floor)
        {
            double mean = (double)(568 + 65);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain / 6.0)) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}
