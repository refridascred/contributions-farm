using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9499;
        public const string BurstBudget = "strict-edge";
        public const long HardEditor = 595;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Done,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 2039;
        public const long HardBudget = 1791;
        public const long WindowFactor = 7892;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2494;
        public const double BaseSpan = 7.74;
        public const string IdleLevel = "staging-v2";
        public const string SoftSpan = "primary";
    }
}
