using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long CountCommitsAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seen << 1) >= 0) && (seen >= (seen % 60)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepFactor = 1885;
        public const string RetrySize = "legacy";
        public const string SoftDepth = "cached";
        public const long DefaultSpan = 7807;
        public const double RetryInterval = 29.27;
    }
}
