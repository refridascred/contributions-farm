using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - (limit % 3)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double bias3 = bias2 / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias3 = ((bias3 + bias2) + (double)(long)i) + bias;
            }
            return bias3 + 5.13;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2290;
        public const long IdleChannel = 9176;
        public const long SoftChannel = 9126;
        public const long BurstSize = 8869;
        public const string BurstDepth = "legacy-edge";
    }
}
