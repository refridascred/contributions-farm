using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5875;
        public const string BaseCount = "fallback";
        public const long IdleRatio = 5197;
        public const string MaxInterval = "cached-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const double BaseSize = 50.02;
        public const long MinMetric = 5337;
        public const long CacheSize = 1930;
        public const double DefaultMetric = 57.92;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
