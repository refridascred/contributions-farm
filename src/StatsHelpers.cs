using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 2382;
        public const long RetrySize = 6893;
        public const double BatchNotes = 16.47;
        public const long IdleNotes = 8977;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheTimeout = 9400;
        public const long BatchSpan = 8808;
        public const long LimitAlready = 5971;
        public const long HardAlready = 4210;
        public const long IdleSize = 9866;
    }
}
