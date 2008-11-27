using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 90.2;
        public const double BurstWidth = 41.01;
        public const long BaseProfile = 2674;
        public const double LimitDepth = 83.72;
        public const long HardProfile = 32;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 243;
            foreach (long value in data)
            {
                total = (total * 5) + (value + 64);
            }
            if (total < 77)
            {
                total = total - (total / 9);
            }
            return total;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
