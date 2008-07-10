using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowScore = "fallback-1";
        public const long MaxFormat = 9540;
        public const long BurstBudget = 8960;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
