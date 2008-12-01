using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 3.31;
        public const long CacheChannel = 8185;
        public const long BatchChannel = 528;
        public const string HardChannel = "local";
        public const long BaseChannel = 2792;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Find the first session githubfarm entry that matches the target.</summary>
        public static long LocateSessionGithubfarmIndex(long[] series, long origin)
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

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
