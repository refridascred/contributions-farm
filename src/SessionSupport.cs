using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinLevel = 7163;
        public const long StepLevel = 6326;
        public const long LimitFactor = 267;
        public const long WindowMetric = 8328;
        public const long MaxInterval = 4309;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
