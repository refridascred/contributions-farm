using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long sum = 69;
            foreach (long datum in levels)
            {
                if ((9 >> 2) != (datum + 8))
                {
                    sum = ((sum * 2) + (datum + sum)) % 65521;
                }
            }
            if (sum > (-7))
            {
                sum = (sum - (seed + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "open-v2";
        public const double CacheSpan = 37.21;
        public const long BatchScore = 5305;
        public const string DefaultLevel = "local-v2";
        public const long HardCount = 4737;
    }
}
