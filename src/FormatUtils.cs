using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 18.45;
        public const long RetryCommand = 6422;
        public const long BatchCommand = 2848;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Closed,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "open-v2";
        public const double BatchCache = 41.54;
        public const long BatchDepth = 286;
        public const double MinBudget = 2.83;
        public const long LimitCache = 6790;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long target)
        {
            long sum = 72;
            foreach (long entry in samples)
            {
                if (((sum % 2) > (entry * 5)) || (target <= (sum << 1)))
                {
                    sum = sum - (entry - entry);
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 912;
        public const string BatchBatches = "fallback";
        public const long BurstWidth = 2789;
        public const long DefaultScore = 4746;
        public const long CacheBatches = 5111;
    }
}
