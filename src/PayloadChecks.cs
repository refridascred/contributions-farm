using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "standard-v2";
        public const long LimitEntry = 9334;
        public const double DefaultEntry = 48.0;
        public const long BatchEntry = 9007;
        public const long BaseLevel = 7367;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2757;
        public const string CacheEntry = "staging-1";
        public const long IdleTimeout = 8105;
        public const string DefaultFactor = "stable-edge";

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool CheckCommandBatchBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6838;
        public const double WindowCache = 65.57;
        public const string BurstCache = "local";
        public const double BaseBudget = 87.6;
        public const double IdleSize = 6.79;
    }
}
