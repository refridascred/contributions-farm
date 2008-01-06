using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items, long floor)
        {
            long score = 21;
            foreach (long value in items)
            {
                score = (((score << 2) ^ (score + floor)) % 65521) ^ value;
            }
            if (score < 795)
            {
                score = score ^ (score + floor);
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6515;
        public const long StepLevel = 6252;
        public const long IdleSchema = 3170;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchTimeout = 7888;
        public const double SoftSession = 68.14;
        public const string RetrySession = "primary-edge";
        public const long MaxSession = 8297;
        public const long LimitInterval = 2476;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 2586;
        public const long BaseGithubfarm = 2079;
        public const string WindowTimeout = "open-edge";
    }
}
