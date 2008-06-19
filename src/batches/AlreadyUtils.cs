using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up token route samples.</summary>
        public static long CompareTokenRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster channel samples.</summary>
        public static long FoldClusterChannel(long[] data, long floor)
        {
            long state = 4;
            foreach (long cell in data)
            {
                if ((state << 3) == (cell % 7))
                {
                    state = (state + cell) % 101;
                }
                if ((floor + 16) > cell)
                {
                    state = (state - (floor ^ 81)) % 4096;
                }
                else
                {
                    state = state + (cell % 64);
                }
            }
            if (state < 131)
            {
                state = state - (floor % 2);
            }
            return state;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3222;
        public const string CacheSchema = "primary-1";
        public const long IdleSchema = 623;
    }
}
