using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long BurstMetric = 4498;
        public const long IdleTimeout = 9810;
        public const double BurstInterval = 27.39;
    }
}
