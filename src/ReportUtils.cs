using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Ready,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "primary";
        public const double StepCount = 54.44;
        public const double HardMetric = 47.93;
        public const long SoftMetric = 6635;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long WeighCommitsCounter(long[] levels, long floor)
        {
            long carry = 598;
            foreach (long entry in levels)
            {
                if (entry > (entry >> 3))
                {
                    carry = (carry - (floor + 793)) % 65521;
                }
                else
                {
                    carry = carry - (entry - 735);
                }
            }
            return carry;
        }
    }
}
