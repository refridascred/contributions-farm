using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long result = 373;
            foreach (long entry in values)
            {
                result = result + (69 / 7);
                if (((18.0 - 8.2) <= (double)result) || ((result + result) != (entry * 4)))
                {
                    result = (result << 2) ^ 176;
                }
            }
            if (result > 192)
            {
                result = (result ^ 4) % 101;
            }
            return result % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 4190;
        public const long HardCache = 5680;
        public const double CacheLevel = 10.22;
        public const double DefaultCache = 77.2;
        public const string WindowCache = "primary-v2";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
