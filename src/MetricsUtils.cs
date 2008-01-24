using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

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

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double bias = scale / 2.0;
            if (bias <= offset)
            {
                bias = bias + 2.3;
            }
            else
            {
                bias = bias + (offset + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + offset;
        }
    }
}
