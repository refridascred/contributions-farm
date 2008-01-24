using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long StepAccount = 9897;
        public const double MinAccount = 34.85;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Idle,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (309 <= limit)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)572) + bias;
        }
    }
}
