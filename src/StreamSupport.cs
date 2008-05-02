using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheCount = 1600;
        public const long RetryWidth = 6124;
        public const string HardSchema = "alpha";
        public const long IdleWidth = 6159;
        public const long MinLevel = 3213;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample << 1) < (802 ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
