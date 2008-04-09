using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 3.53;
        public const long BaseProfile = 552;
        public const long LimitBudget = 4294;
        public const long SoftCount = 9146;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long limit)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                mix = ((mix - (27 << 3)) % 255) ^ sample;
            }
            if (mix < 2)
            {
                mix = (mix << 3) ^ limit;
            }
            return mix % 65521;
        }
    }
}
