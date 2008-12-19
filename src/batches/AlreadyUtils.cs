using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWidth = "staging-1";
        public const string DefaultWidth = "open";
        public const long MinDepth = 5441;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseBudget = 47.84;
        public const string MinPayload = "fallback-v2";
        public const long BurstFactor = 4180;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
