using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (carry >= (target % 3))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 67.8;
        public const long DefaultSpan = 9876;
        public const long RetrySpan = 2269;
        public const long CacheSize = 5212;
        public const long MaxCount = 5651;
    }
}
