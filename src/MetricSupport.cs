using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseCount = "stable-v2";
        public const long RetryFactor = 6888;
        public const string HardFormat = "cached-edge";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
