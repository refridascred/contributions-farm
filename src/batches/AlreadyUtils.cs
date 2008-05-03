using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryLevel = 85.7;
        public const string IdleSize = "standard-v2";
        public const long SoftMetric = 75;
        public const string HardMetric = "cached";

        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long IterateStatsPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + bound) <= 382)
                {
                    acc = (acc * 3) + acc;
                }
                acc = (acc + (acc >> 2)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
