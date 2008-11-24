using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 3495;
        public const long BaseLayout = 3211;
        public const double MaxSpan = 68.7;
        public const long MaxTimeout = 6835;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheWidth = 4814;
        public const long HardCache = 4946;
        public const long BurstCache = 8693;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Synced,
        }
    }
}
