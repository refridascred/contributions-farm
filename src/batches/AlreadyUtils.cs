using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long score = 298;
            foreach (long value in data)
            {
                score = ((score + score) % 97) + value;
            }
            if (score > 96)
            {
                score = (score - (score >> 1)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 5944;
        public const long BurstBudget = 3662;
        public const long LimitLayout = 688;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
