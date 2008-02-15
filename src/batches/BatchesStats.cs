using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 4678;
        public const long MinSpan = 8638;
        public const string SoftContributi = "local";
        public const long BaseBudget = 815;
        public const long IdleScore = 2814;

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
