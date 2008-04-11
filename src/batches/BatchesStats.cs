using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long IdleTimeout = 5207;
        public const double MinSize = 78.59;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 7833;
        public const long RetryTimeout = 9276;
        public const string SoftCluster = "standard";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
