using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardWidth = 11.64;
        public const long RetryBatches = 3093;
        public const long RetryBudget = 6012;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
