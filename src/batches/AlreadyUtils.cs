using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4442;
        public const string WindowSize = "legacy-v2";
        public const double BurstBudget = 74.99;
        public const long SoftSpan = 6034;
        public const long BaseCount = 5118;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long seed)
        {
            long score = 86;
            foreach (long value in items)
            {
                score = ((((score * 2) + (855 % 2)) % 65521) + value) + seed;
            }
            return score;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
