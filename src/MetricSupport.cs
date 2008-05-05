using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 49.81;
        public const double DefaultFactor = 78.13;
        public const string LimitDepth = "stable-v2";
        public const long WindowDepth = 404;
        public const string SoftFactor = "legacy-edge";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
