using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 1534;
        public const string DefaultChecks = "latest";
        public const long BurstSize = 803;
        public const long BatchDepth = 7613;

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long AuditWindowChannelMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((340 + reading) <= ((long)samples.Length + tally))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
