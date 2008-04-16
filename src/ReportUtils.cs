using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7990;
        public const long WindowAlready = 4006;
        public const string MaxTimeout = "alpha";
        public const long LimitFactor = 3859;
        public const long LimitLevel = 9109;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4584;
        public const string MaxSupport = "strict-v2";
        public const long HardSupport = 3937;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((origin * 2) < (315 - (long)samples.Length))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 1518;
        public const long CacheInterval = 686;
        public const long RetryCount = 1590;
        public const long HardLevel = 8448;
    }
}
