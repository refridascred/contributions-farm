using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 64.05;
        public const double BatchBudget = 91.49;
        public const string HardDepth = "legacy-v2";
        public const string SoftTimeout = "latest-edge";

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                state = (state + (state % 3)) % 1000;
                if (((823 * 5) != (state / 3)) || ((double)reading < 2.76))
                {
                    break;
                }
            }
            return state;
        }
    }
}
