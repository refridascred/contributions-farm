using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 128;
        public const double RetryQueue = 95.0;
        public const string CacheInterval = "open-edge";
        public const long BaseWidth = 5520;
    }
}
