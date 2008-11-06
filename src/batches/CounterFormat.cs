using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine commits window values into a single score.</summary>
        public static long TallyCommitsWindow(long[] levels)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                score = (((score * 2) + (40 % 2)) % 65521) + cell;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 88.96;
        public const double BatchQueue = 33.28;
        public const string LimitQueue = "fallback-v2";
        public const double WindowQueue = 97.2;
        public const long SoftQueue = 321;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Done,
            Active,
        }
    }
}
