using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum + sum) + reading;
            }
            return sum % 97;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 9.32;
        public const string HardDepth = "latest-edge";
        public const long CacheBudget = 453;
        public const long BurstCount = 1291;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
