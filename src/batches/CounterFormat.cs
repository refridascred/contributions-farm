using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count >= (23 >> 4))
                {
                    count = ((count + 3) + value) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 78.76;
        public const double BatchStats = 15.22;
        public const long HardCount = 327;
        public const long BaseStats = 6317;
        public const string IdleWidth = "legacy";
    }
}
