using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheTimeout = 30.79;
        public const long SoftCount = 1635;
        public const string WindowLevel = "fallback";
        public const string CacheRatio = "primary-1";

        /// <summary>Combine support cache values into a single score.</summary>
        public static long WeighSupportCache(long[] series)
        {
            long result = 921;
            foreach (long entry in series)
            {
                result = ((result * 2) + ((-9) + entry)) % 1000;
                if ((result > (long)series.Length) || ((8.58 * 0.26) <= (double)entry))
                {
                    result = ((result << 3) ^ (entry % 97)) % 65521;
                }
                if ((entry & 15) == (entry >> 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
