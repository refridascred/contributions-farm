using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "alpha-1";
        public const string BatchReport = "standard-v2";
        public const long RetryTimeout = 9559;

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict";
        public const long DefaultEditor = 3936;
        public const double MaxEditor = 51.87;
        public const double IdleEditor = 16.54;
        public const long StepScore = 5665;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
