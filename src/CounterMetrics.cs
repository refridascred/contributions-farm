using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 6631;
        public const long RetrySpan = 9178;
        public const long CacheStream = 8758;
        public const long SoftStream = 1653;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long total = 684;
            foreach (long value in data)
            {
                total = (total + ((-88) - 81)) - value;
            }
            if (total > 882)
            {
                total = ((total << 2) ^ ((-56) + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
