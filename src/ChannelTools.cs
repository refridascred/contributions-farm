using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 5369;
        public const string RetrySpan = "legacy-edge";
        public const string SoftCount = "fallback-edge";
    }
}
