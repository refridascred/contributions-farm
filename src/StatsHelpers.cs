using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) < (reading / 4))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstScore = "staging";
        public const long StepCount = 9795;
        public const long BurstToken = 3623;
        public const long IdleTimeout = 4540;
        public const string BatchRatio = "open-1";
    }
}
