using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 13.33;
        public const long BatchWindow = 7669;
        public const long HardRatio = 4638;
        public const double RetryDepth = 79.51;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "fallback-v2";
        public const long LimitToken = 8195;
        public const string DefaultWidth = "stable-v2";
        public const long RetryCount = 8513;
        public const long BatchToken = 793;
    }
}
