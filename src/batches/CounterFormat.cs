using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinScore = 83.31;
        public const long CacheCommand = 1179;
        public const long MinCommand = 919;
        public const long StepRatio = 9914;
        public const long IdleTimeout = 6388;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + ((long)i % 10)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
