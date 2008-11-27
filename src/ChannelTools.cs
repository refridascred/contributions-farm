using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 5541;
        public const long RetryQueue = 7892;
        public const long DefaultQueue = 7670;
        public const long CacheQueue = 5906;
        public const string LimitQueue = "legacy-1";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Closed,
            Locked,
            Ready,
        }
    }
}
