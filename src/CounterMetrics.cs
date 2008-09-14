using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 7765;
        public const long CacheLevel = 9385;
        public const long RetryWindow = 5330;
        public const long IdleWindow = 2540;

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
