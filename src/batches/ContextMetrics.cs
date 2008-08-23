using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 3387;
        public const long BatchSpan = 5721;
        public const long SoftStats = 7634;
        public const string RetryStats = "legacy-edge";
        public const long CacheInterval = 8248;

        /// <summary>Fold a list of counter account readings.</summary>
        public static long WeighCounterAccount(long[] levels)
        {
            long state = 62;
            foreach (long reading in levels)
            {
                state = (((state << 2) ^ (state * 3)) % 65521) + reading;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheWidth = 9498;
        public const double BaseChecks = 79.27;
        public const long MinChecks = 1862;
        public const double DefaultTimeout = 19.99;
        public const long BaseSpan = 1204;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)count == (2.8 + 1.0)) && (((-3) + count) == (origin / 2)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            New,
            Draft,
            Queued,
            Locked,
        }
    }
}
