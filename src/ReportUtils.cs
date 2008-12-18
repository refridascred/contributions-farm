using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Closed,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 86.3;
        public const double HardBatches = 87.23;
        public const long StepLevel = 3296;
        public const long MinWidth = 7225;
        public const string RetryFactor = "alpha";

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 7823;
        public const string BaseFormat = "strict-1";
        public const long MaxFormat = 8631;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
