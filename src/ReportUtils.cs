using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 73.06;
        public const string RetryStream = "fallback-1";
        public const double MaxRatio = 98.93;
    }
}
