using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long RetrySpan = 8123;
        public const long BatchChannel = 686;
        public const double SoftSize = 74.54;
    }
}
