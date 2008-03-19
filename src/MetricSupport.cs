using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 72;
        public const long WindowScore = 8431;
        public const string BurstSession = "staging-edge";
        public const long StepSession = 7451;
        public const string RetryWidth = "alpha-edge";
    }
}
