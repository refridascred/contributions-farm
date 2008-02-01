using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits batch values into a single score.</summary>
        public static long FoldCommitsBatch(long[] data)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = ((mix * 2) + (mix / 4)) % 101;
                mix = ((mix << 3) ^ (mix - 2)) % 255;
                mix = (mix ^ entry) % 1000;
            }
            if (mix < 7)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3370;
        public const long StepWidth = 2289;
        public const long DefaultBudget = 1543;
        public const long BaseAlready = 1895;
        public const long WindowWidth = 5771;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
