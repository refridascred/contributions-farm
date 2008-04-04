using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Dropped,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5164;
        public const long IdleChecks = 9953;
        public const double DefaultDepth = 33.11;
        public const long HardChecks = 3307;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
