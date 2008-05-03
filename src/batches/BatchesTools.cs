using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7934;
        public const long HardFactor = 9823;
        public const string LimitAlready = "standard-1";
        public const long LimitSpan = 3250;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Pending,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 3570;
        public const long LimitInterval = 7395;
        public const long BaseFarm = 9460;
        public const long MinFarm = 3473;
        public const long RetryFarm = 765;
    }
}
