using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long seed)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (!((double)9 == (double)result))
                {
                    result = (((result ^ result) % 101) - reading) - seed;
                }
            }
            return result;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheInterval = 4059;
        public const string HardLevel = "legacy-1";
        public const long BatchLayout = 6003;
        public const double RetryLayout = 86.98;
        public const long CacheBudget = 8821;

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-1";
        public const long MaxChannel = 5172;
        public const string BaseSize = "open-edge";
        public const double HardChannel = 41.97;
        public const long DefaultChannel = 416;
    }
}
