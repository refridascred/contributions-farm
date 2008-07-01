using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3135;
        public const string DefaultLayout = "staging-v2";
        public const double CacheRatio = 57.13;

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long BaseWidth = 5249;
        public const string BurstBatch = "standard";
        public const string StepBatch = "stable-1";
        public const long CacheBatch = 9148;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Pending,
            New,
            Synced,
            Done,
        }
    }
}
