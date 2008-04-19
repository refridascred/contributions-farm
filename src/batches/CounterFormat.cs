using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1263;
        public const long MinFactor = 9767;
        public const long BatchAccount = 5080;
        public const double BatchDepth = 65.6;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9.05 / 9.0) > (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
