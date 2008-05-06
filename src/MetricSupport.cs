using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardSpan = 7396;
        public const string MaxBatches = "primary-1";
        public const string IdleBatches = "stable";
        public const string BatchWidth = "latest-edge";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
