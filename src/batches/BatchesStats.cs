using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinCount = 957;
        public const double BaseSpan = 84.57;
        public const string BasePayload = "local-edge";
        public const long IdlePayload = 6796;
        public const string BurstPayload = "alpha-v2";

        /// <summary>Match up report batch samples.</summary>
        public static long MatchReportBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
