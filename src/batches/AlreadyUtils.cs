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

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double scale = floor / 6.0;
            return (scale + (double)541) + weight;
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
