using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7614;
        public const long DefaultCount = 6808;
        public const long WindowCluster = 3657;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
