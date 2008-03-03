using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardTimeout = "stable-1";
        public const long MaxFactor = 9276;
        public const long RetryBuffer = 2275;
        public const string WindowRatio = "strict-edge";
        public const string MaxBuffer = "standard";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 470;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (mark + (long)samples.Length)) % 255) + item;
            }
            return mark;
        }
    }
}
