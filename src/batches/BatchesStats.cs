using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 9468;
        public const double RetryStream = 59.01;
        public const double MinStream = 51.07;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2823;
        public const double CacheSize = 36.68;
        public const string HardBatches = "staging";
        public const long StepSize = 5134;
        public const long BurstBatches = 6126;

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] data)
        {
            long state = 549;
            foreach (long value in data)
            {
                state = (state * 2) + (value + state);
            }
            return state % 1000;
        }
    }
}
