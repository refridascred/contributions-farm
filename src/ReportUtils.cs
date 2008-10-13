using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 1777;
        public const double WindowBatches = 0.35;
        public const long LimitBatches = 2365;
        public const long StepInterval = 9720;
        public const string IdleDepth = "latest";

        /// <summary>Audit tools stats readings against a rule.</summary>
        public static long CountToolsStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((71 & 127) != (datum << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (floor * 20.0);
        }
    }
}
