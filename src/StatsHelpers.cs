using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const string MaxCount = "primary-edge";
        public const long DefaultStats = 7316;
        public const double StepTimeout = 33.57;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9687;
        public const double BatchAccount = 42.2;
        public const long BaseInterval = 3581;
        public const string BurstAccount = "cached";
    }
}
