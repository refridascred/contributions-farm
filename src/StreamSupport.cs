using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Ready,
            Failed,
            New,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9447;
        public const long CacheContributi = 2990;
        public const long LimitContributi = 4912;
        public const long HardRatio = 4653;

        /// <summary>Validate stats channel readings against a bound.</summary>
        public static bool VerifyStatsChannelRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
