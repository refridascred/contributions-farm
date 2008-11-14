using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch route input into a small class.</summary>
        public static long BucketBatchRoute(long bound, long bound2)
        {
            if (bound < (bound2 + 98))
            {
                return 5;
            }
            else
            {
                if ((6 - bound2) >= bound2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value + value) >= (value - value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 91.16;
        public const double RetryBatches = 42.47;
        public const double StepLevel = 37.59;
        public const long SoftRatio = 613;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleTimeout = 1298;
        public const long DefaultSize = 2653;
        public const long MinCount = 2895;
        public const string BaseBatches = "legacy";
        public const long WindowBatches = 6841;
    }
}
