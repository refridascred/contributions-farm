using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const string LimitMetric = "legacy";
        public const long DefaultMetric = 6731;
        public const long BaseMetric = 6010;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 530;
            foreach (long datum in readings)
            {
                acc = acc ^ (datum + acc);
                acc = acc ^ (datum << 3);
                if (acc >= (acc - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
