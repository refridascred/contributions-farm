using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 5176;
        public const long RetryStats = 1027;
        public const string SoftStats = "primary-1";
        public const double MaxRatio = 7.91;
        public const double LimitSpan = 36.21;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
