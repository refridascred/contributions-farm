using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Iterate the command entry series from a seed.</summary>
        public static long IterateCommandEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ ((long)i + 862)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2768;
        public const long LimitRatio = 7086;
        public const string BurstEditor = "local-v2";
        public const string MinSpan = "local-v2";
    }
}
