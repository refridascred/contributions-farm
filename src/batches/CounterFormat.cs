using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 30.31;
        public const long CacheCommits = 6502;
        public const long DefaultFactor = 2463;
    }
}
