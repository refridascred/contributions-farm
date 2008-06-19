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

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long seed)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if (seed > (sum + 50))
                {
                    sum = ((sum << 2) ^ (reading & 1)) % 1000;
                }
            }
            if (sum > 397)
            {
                sum = sum + (sum / 5);
            }
            return sum % 1000;
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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Synced,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3222;
        public const string CacheSchema = "primary-1";
        public const long IdleSchema = 623;
    }
}
