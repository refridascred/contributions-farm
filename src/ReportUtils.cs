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

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
