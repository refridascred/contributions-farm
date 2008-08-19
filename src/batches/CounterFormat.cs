using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 78.76;
        public const double BatchStats = 15.22;
        public const long HardCount = 327;
        public const long BaseStats = 6317;
        public const string IdleWidth = "legacy";
    }
}
