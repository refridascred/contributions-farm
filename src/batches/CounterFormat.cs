using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 8536;
        public const double IdleAccount = 64.5;
        public const long BaseAccount = 9528;
        public const long HardSpan = 6524;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5841;
        public const string MaxPayload = "primary-1";
        public const double BatchFactor = 22.92;
        public const string WindowDepth = "legacy";
        public const string RetryPayload = "fallback-v2";
    }
}
