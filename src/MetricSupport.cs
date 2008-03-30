using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long BaseCommand = 8317;
        public const long CacheCommand = 9888;
        public const string IdleRatio = "stable-1";
        public const string CacheRatio = "alpha-1";

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
