using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long SeekFormatContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Closed,
            Active,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
