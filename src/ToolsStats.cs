using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            if ((double)bound < (5.0 * 4.46))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) <= (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 4102;
        public const long MaxQueue = 2958;
        public const string BaseSpan = "latest-edge";
    }
}
