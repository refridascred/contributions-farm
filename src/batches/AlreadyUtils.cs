using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "strict-v2";
        public const string BurstReport = "standard";
        public const long BatchReport = 1563;
        public const double LimitReport = 91.56;
        public const long IdleDepth = 1314;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ (45 + floor)) % 1000;
                state = (state - (floor << 2)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
